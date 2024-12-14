using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HandleError(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    return View("Error404");
                default:
                    return View("Error");
            }
        }

        [Route("/Error/")]
        public IActionResult HandleError1()
        {
            var statusCode = HttpContext.Response.StatusCode;
            switch (statusCode)
            {
                case 404:
                    return View("Error404");
                case 500:
                    return View("Error500");
                default:
                    return View("Error");
            }
        }
    }
}
