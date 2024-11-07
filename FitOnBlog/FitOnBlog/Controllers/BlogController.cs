using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
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
