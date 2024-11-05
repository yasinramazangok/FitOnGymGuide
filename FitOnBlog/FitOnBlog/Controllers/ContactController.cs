using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MailSubscribe()
        {
            return View();
        }
    }
}
