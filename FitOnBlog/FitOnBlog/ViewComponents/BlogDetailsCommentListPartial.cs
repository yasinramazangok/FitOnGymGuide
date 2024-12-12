using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    [AllowAnonymous]
    public class BlogDetailsCommentListPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public BlogDetailsCommentListPartial(ICommentService commentService)
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
