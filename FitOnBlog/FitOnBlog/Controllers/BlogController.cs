using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FitOnBlog.Controllers
{
    //[Authorize]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _blogService.GetListAll();
            return View(values);
        }

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

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            _blogService.Insert(blog);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBlog(int id)
        {
            var value = _blogService.GetById(id);
            _blogService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var value = _blogService.GetById(id);
            return View(value);
        }

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
            var blogDetails = _blogService.GetBlogById(id);

            var selectedBlog = blogDetails.FirstOrDefault(b => b.BlogId == id);

            ViewBag.authorId = selectedBlog?.AuthorId;

            ViewBag.id = id;

            return View(blogDetails);
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
            var blogListByCategory = _blogService.GetBlogsByCategoryId(id);

            var selectedBlog = blogListByCategory.FirstOrDefault();

            ViewBag.categoryName = selectedBlog?.Category?.Name;

            ViewBag.categoryDescription = selectedBlog?.Category?.Description;

            return View(blogListByCategory);
        }

        #endregion
    }
}
