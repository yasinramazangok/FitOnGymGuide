using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LeaveComment(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult LeaveComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _commentService.Insert(comment);
                return RedirectToAction("BlogDetails", "Blog", new { id = comment.BlogId });
            }
            return View();
        }
    }
}
