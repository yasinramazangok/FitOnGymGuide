using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json.Serialization;
using X.PagedList.Extensions;

namespace FitOnBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ILogger<BlogController> _logger;

        public BlogController(IBlogService blogService, ILogger<BlogController> logger)
        {
            _blogService = blogService;
            _logger = logger;
        }

        private const int PageSize = 6;

        private IEnumerable<Blog> GetBlogsForCurrentUser()
        {
            if (User.IsInRole("Admin"))
            {
                return _blogService.GetListAll();
            }
            else if (User.IsInRole("Yazar"))
            {
                string authorUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return _blogService.GetBlogsByAuthorId(authorUserId);
            }
            return new List<Blog>();
        }

        #region Admin Operations

        [Authorize(Roles = "Admin, Yazar")]
        public IActionResult Index()
        {
            var values = GetBlogsForCurrentUser();
            return View(values);
        }

        [Authorize(Roles = "Admin, Yazar")]
        public IActionResult BlogOverview()
        {
            var values = GetBlogsForCurrentUser();
            return View(values);
        }

        [Authorize(Roles = "Yazar")]
        [HttpGet]
        public IActionResult AddBlog()
        {
            /* 
             * When adding a blog, the category selection is made from the dropdownlist. 
             * Here, we could list the categories by injecting ICategoryService.
             * But it would not comply with SRP(Single Responsibility Principle) and coupling would increase.
             * So, we use view component instead.
            */
            return View();
        }

        [Authorize(Roles = "Yazar")]
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(blog);

            if (validationResult.IsValid)
            {
                _blogService.Insert(blog);
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

        [Authorize(Roles = "Yazar")]
        public IActionResult DeleteBlog(int id)
        {
            var value = _blogService.GetById(id);
            _blogService.Delete(value);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Yazar")]
        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var value = _blogService.GetById(id);
            return View(value);
        }

        [Authorize(Roles = "Yazar")]
        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(blog);

            if (validationResult.IsValid)
            {
                _blogService.Update(blog);
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
        public IActionResult BlogDetails(int id)
        {
            try
            {
                var blogDetails = _blogService.GetBlogById(id);

                var selectedBlog = blogDetails.FirstOrDefault(b => b.BlogId == id);

                ViewBag.authorId = selectedBlog?.AuthorId;

                ViewBag.id = id;

                return View(blogDetails);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Blog ayrıntıları getirilirken hata oluştu. BlogId: {Id}", id);
                throw;
            }
        }

        [AllowAnonymous]
        public IActionResult BlogCover()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult BlogContent()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult BlogsByCategory(int id, int pageNumber = 1)
        {
            // BlogsByCategoryViewModel will be defined and used here for a more readable and type-safe structure.
            try
            {
                var blogListByCategory = _blogService.GetBlogsByCategoryId(id).ToPagedList(pageNumber, PageSize);

                var selectedBlog = blogListByCategory.FirstOrDefault();

                ViewBag.categoryName = selectedBlog?.Category?.Name;

                ViewBag.categoryDescription = selectedBlog?.Category?.Description;

                return View(blogListByCategory);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Blog ayrıntıları getirilirken hata oluştu. BlogId: {Id}", id);
                throw;
            }
        }

        #endregion
    }
}
