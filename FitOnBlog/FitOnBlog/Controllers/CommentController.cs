using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CommentList()
        {
            return View();
        }

        public IActionResult LeaveComment()
        {
            return View();
        }
    }
}
