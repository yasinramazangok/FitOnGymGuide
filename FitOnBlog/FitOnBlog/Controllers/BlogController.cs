using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
