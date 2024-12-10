using BusinessLayer.Abstracts;
using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using FitOnBlog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<FitOnBlogUser> _signInManager;
        private readonly UserManager<FitOnBlogUser> _userManager;
        private readonly IAuthorService _authorService;

        public AccountController(SignInManager<FitOnBlogUser> signInManager, UserManager<FitOnBlogUser> userManager, IAuthorService authorService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _authorService = authorService;
        }

        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);

                if (user != null && model.Role != null && await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles.Contains(model.Role))
                    {
                        var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            if (model.Role == "Admin")
                                return RedirectToAction("Index", "Blog");
                            if (model.Role == "Yazar")
                                return RedirectToAction("Index", "Blog");
                            else
                                return RedirectToLocal(returnUrl);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Seçilen rol ile eşleşen bir kullanıcı bulunamadı.");
                    }
                }
                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
            }
            else
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
            }
            return View(model);
        }

        public IActionResult Register(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                FitOnBlogUser fitOnBlogUser = new()
                {
                    Name = registerViewModel.Name,
                    UserName = registerViewModel.Email,
                    Email = registerViewModel.Email,
                };

                var result = await _userManager.CreateAsync(fitOnBlogUser, registerViewModel.Password!);

                if (result.Succeeded)
                {
                    if(registerViewModel.Role == "Admin")
                    {
                        await _userManager.AddToRoleAsync(fitOnBlogUser, "Admin");
                    }
                    else if (registerViewModel.Role == "Yazar")
                    {
                        await _userManager.AddToRoleAsync(fitOnBlogUser, "Yazar");

                        Author author = new()
                        {
                            UserId = fitOnBlogUser.Id,
                            Name = registerViewModel.Name,
                            Email = registerViewModel.Email,
                            Password = registerViewModel.Password,
                            PhoneNumber = registerViewModel.PhoneNumber,
                            ImageUrl = registerViewModel.ImageUrl,
                            Title = registerViewModel.Title,
                            Expertises = registerViewModel.Expertises,
                            About = registerViewModel.About,
                        };

                        _authorService.Insert(author);

                    }
                    return RedirectToLocal(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Default");
        }

        private IActionResult RedirectToLocal(string? returnUrl)
        {
            return !string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl)
                ? Redirect(returnUrl)
                : RedirectToAction("Index", "Default");
        }
    }
}
