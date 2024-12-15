using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            AboutValidator aboutValidator = new AboutValidator();
            ValidationResult validationResult = aboutValidator.Validate(about);

            if (validationResult.IsValid)
            {
                _aboutService.Update(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        #endregion

        #region UI Operations

        [AllowAnonymous]
        public IActionResult Home()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult AboutCover()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AboutContent1()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult MeetTheTeam()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AboutContent2()
        {
            return View();
        }

        #endregion
    }
}
