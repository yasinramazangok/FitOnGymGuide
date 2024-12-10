using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    [Authorize(Roles ="Admin, Yazar")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _commentService.GetListAll();
            return View(values);
        }

        public IActionResult RemovedCommentsList()
        {
            var values = _commentService.GetListStatusFalse();
            return View(values);
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            _commentService.ChangeCommentStatusToFalse(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _commentService.ChangeCommentStatusToTrue(id);
            return RedirectToAction("RemovedCommentsList");
        }

        public IActionResult CommentListByBlogId(int id)
        {
            return ViewComponent("AdminBlogCommentListPartial", new { id });
        }

        #endregion

        #region UI Operations

        [AllowAnonymous]
        [HttpGet]
        public IActionResult LeaveComment(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [AllowAnonymous]
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

        #endregion     
    }
}
