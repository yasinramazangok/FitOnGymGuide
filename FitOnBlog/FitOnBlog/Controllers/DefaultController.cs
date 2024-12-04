using BusinessLayer.Abstracts;
using FitOnBlog.Models;
using FitOnBlog.ViewComponents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;

namespace FitOnBlog.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index(int pageNumber = 1)
        {
            return View(pageNumber);
        }
    }
}
