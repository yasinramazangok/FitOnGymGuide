using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class BlogDetailsAuthorPopularBlogsPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogDetailsAuthorPopularBlogsPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var authorPopularBlogsInBlogDetails = _blogService.GetBlogsByAuthorId(id);
            return View(authorPopularBlogsInBlogDetails);
        }
    }
}
