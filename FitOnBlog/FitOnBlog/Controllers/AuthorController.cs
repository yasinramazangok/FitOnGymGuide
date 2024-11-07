using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorAbout()
        {
            return View();
        }

        public IActionResult AuthorPopularPosts()
        {
            return View();
        }
    }
}
