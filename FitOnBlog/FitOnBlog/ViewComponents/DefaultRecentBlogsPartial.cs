using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Extensions;
using X.PagedList.Mvc;
using X.PagedList.Mvc.Core;

namespace FitOnBlog.ViewComponents
{
    public class DefaultRecentBlogsPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public DefaultRecentBlogsPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int pageNumber = 1)
        {
            var recentBlogsList = _blogService.GetListAll().ToPagedList(pageNumber, 6);

            return View(recentBlogsList);

        }
    }
}
