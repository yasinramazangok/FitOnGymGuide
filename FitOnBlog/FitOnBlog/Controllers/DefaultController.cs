using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
