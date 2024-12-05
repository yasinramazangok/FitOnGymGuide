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

        #region Admin Operations

        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region UI Operations

        public IActionResult AuthorAbout()
        {
            return View();
        }

        #endregion
    }
}
