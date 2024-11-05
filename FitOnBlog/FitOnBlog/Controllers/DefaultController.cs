using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecentPosts()
        {
            return View();
        }

        public IActionResult FeaturedPosts()
        {
            return View();
        }

        public IActionResult OtherFeaturedPosts()
        {
            return View();
        }
    }
}
