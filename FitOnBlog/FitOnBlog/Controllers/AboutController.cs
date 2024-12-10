using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    [Authorize]
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

        [AllowAnonymous]
        public IActionResult Home()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult AboutCover()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AboutContent1()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult MeetTheTeam()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AboutContent2()
        {
            return View();
        }

        #endregion
    }
}
