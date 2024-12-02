using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class EmailSubscriptionController : Controller
    {
        private readonly IEmailSubscriptionService _emailSubscriptionService;

        public EmailSubscriptionController(IEmailSubscriptionService emailSubscriptionService)
        {
            _emailSubscriptionService = emailSubscriptionService;
        }

        [HttpGet]
        public IActionResult AddSubscriber()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubscriber(EmailSubscription emailSubscription)
        {
            _emailSubscriptionService.Insert(emailSubscription);
            return RedirectToAction("Index", "Default");
        }
    }
}
