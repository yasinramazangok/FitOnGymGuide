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

        public IActionResult BlogByCategory()
        {
            return View();
        }
    }
}
