using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class BlogCommentListByBlogIdPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public BlogCommentListByBlogIdPartial(ICommentService commentService)
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
