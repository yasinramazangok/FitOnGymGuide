using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FitOnBlog.Controllers
{
    //[Authorize]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var message = _contactService.GetById(id);
            return View(message);
        }

        #endregion

        #region UI Operations

        [AllowAnonymous]
        public IActionResult Home()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
            return RedirectToAction("Home", "Contact");
        }

        #endregion
    }
}
