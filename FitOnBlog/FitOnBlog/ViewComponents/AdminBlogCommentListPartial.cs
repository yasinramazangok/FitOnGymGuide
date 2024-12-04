using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class AdminBlogCommentListPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public AdminBlogCommentListPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var commentList = _commentService.GetCommentsByBlogId(id);
            return View(commentList);
        }
    }
}
