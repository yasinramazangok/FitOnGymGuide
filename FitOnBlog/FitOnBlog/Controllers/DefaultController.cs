using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IBlogService _blogService;

        public DefaultController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var blogs = _blogService.GetListAll();
            return View(blogs);
        }

        public IActionResult FeaturedPosts()
        {
            return View();
        }

        public IActionResult RecentPosts()
        {
            return View();
        }

        public IActionResult OtherFeaturedPosts()
        {
            return View();
        }
    }
}
