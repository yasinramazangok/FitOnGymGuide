using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails(int id)
        {
            var blogDetails = _blogService.GetBlogById(id);

            var selectedBlog = blogDetails.FirstOrDefault(b => b.BlogId == id);

            ViewBag.authorId = selectedBlog.AuthorId;

            ViewBag.id = id;

            return View(blogDetails);
        }

        public IActionResult BlogCover()
        {
            return View();
        }

        public IActionResult BlogContent()
        {
            return View();
        }

        public IActionResult BlogsByCategory(int id)
        {
            var blogListByCategory = _blogService.GetBlogsByCategoryId(id);

            var selectedBlog = blogListByCategory.FirstOrDefault();

            ViewBag.categoryName = selectedBlog?.Category?.Name;

            ViewBag.categoryDescription = selectedBlog?.Category?.Description;

            return View(blogListByCategory);
        }
    }
}
