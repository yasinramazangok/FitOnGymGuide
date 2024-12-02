using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult ContactCover()
        {
            return View();
        }

        public IActionResult SendMessage()
        {
            return View();
        }
    }
}
