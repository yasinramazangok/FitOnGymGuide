using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AddSubscriber()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddSubscriber(EmailSubscription emailSubscription)
        {
            EmailSubscriptionValidator emailSubscriptionValidator = new EmailSubscriptionValidator();
            ValidationResult validationResult = emailSubscriptionValidator.Validate(emailSubscription);

            if (validationResult.IsValid)
            {
                _emailSubscriptionService.Insert(emailSubscription);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
