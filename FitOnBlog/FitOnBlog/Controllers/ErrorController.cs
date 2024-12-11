using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/400")]
        public IActionResult BadRequestError()
        {
            return View("BadRequest");
        }

        [Route("Error/500")]
        public IActionResult ServerError()
        {
            return View("ServerError");
        }

        [Route("Error/General")]
        public IActionResult GeneralError()
        {
            return View("GeneralError");
        }
    }
}
