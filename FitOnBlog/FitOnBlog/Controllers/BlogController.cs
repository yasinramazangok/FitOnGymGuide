using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace FitOnBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        #region Admin Operations

        [Authorize(Roles = "Admin, Yazar")]
        public IActionResult Index()
        {
            IEnumerable<Blog> values;

            if (User.IsInRole("Admin"))
            {
                values = _blogService.GetListAll();
            }

            else if (User.IsInRole("Yazar"))
            {
                string authorUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                values = _blogService.GetBlogsByAuthorId(authorUserId);
            }
            else
            {
                values = new List<Blog>();
            }
            return View(values);
        }

        [Authorize(Roles = "Admin, Yazar")]
        public IActionResult BlogOverview()
        {
            IEnumerable<Blog> values;

            if (User.IsInRole("Admin"))
            {
                values = _blogService.GetListAll();
            }

            else if (User.IsInRole("Yazar"))
            {
                string authorUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                values = _blogService.GetBlogsByAuthorId(authorUserId);
            }
            else
            {
                values = new List<Blog>();
            }
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
            if (ModelState.IsValid)
            {
                _blogService.Insert(blog);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize(Roles = "Admin")]
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
            if (ModelState.IsValid)
            {
                _blogService.Update(blog);
                return RedirectToAction("Index");
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
        public IActionResult BlogsByCategory(int id)
        {
            try
            {
                var blogListByCategory = _blogService.GetBlogsByCategoryId(id);

                var selectedBlog = blogListByCategory.FirstOrDefault();

                ViewBag.categoryName = selectedBlog?.Category?.Name;

                ViewBag.categoryDescription = selectedBlog?.Category?.Description;

                return View(blogListByCategory);
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
    }
}
