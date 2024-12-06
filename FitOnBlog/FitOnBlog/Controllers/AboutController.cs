using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
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

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _aboutService.Update(about);
                return RedirectToAction("Index");
            }

            return View();
        }

        #endregion

        #region UI Operations

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

        #endregion
    }
}
