using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBlogService _blogService;

        public AuthorController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorAbout()
        {
            return View();
        }
    }
}
