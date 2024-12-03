using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        public IActionResult AboutCover()
        {
            return View();
        }
        public IActionResult AboutContent1()
        {
            return View();
        }
        public IActionResult MeetTheTeam()
        {
            return View();
        }
        public IActionResult AboutContent2()
        {
            return View();
        }
    }
}
