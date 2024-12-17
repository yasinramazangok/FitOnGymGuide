using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    [AllowAnonymous]
    public class DefaultOtherFeaturedBlogsPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public DefaultOtherFeaturedBlogsPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            ViewData["blogId2"] = _blogService.GetFirstBlogByCategory(2).BlogId;
            ViewData["title2"] = _blogService.GetFirstBlogByCategory(2).Title;
            ViewData["imageUrl2"] = _blogService.GetFirstBlogByCategory(2).ImageUrl;
            ViewData["date2"] = _blogService.GetFirstBlogByCategory(2).Date;

            ViewData["blogId5"] = _blogService.GetFirstBlogByCategory(5).BlogId;
            ViewData["title5"] = _blogService.GetFirstBlogByCategory(5).Title;
            ViewData["imageUrl5"] = _blogService.GetFirstBlogByCategory(5).ImageUrl;
            ViewData["date5"] = _blogService.GetFirstBlogByCategory(5).Date;

            ViewData["blogId3"] = _blogService.GetFirstBlogByCategory(3).BlogId;
            ViewData["title3"] = _blogService.GetFirstBlogByCategory(3).Title;
            ViewData["imageUrl3"] = _blogService.GetFirstBlogByCategory(3).ImageUrl;
            ViewData["date3"] = _blogService.GetFirstBlogByCategory(3).Date;

            ViewData["blogId6"] = _blogService.GetFirstBlogByCategory(6).BlogId;
            ViewData["title6"] = _blogService.GetFirstBlogByCategory(6).Title;
            ViewData["imageUrl6"] = _blogService.GetFirstBlogByCategory(6).ImageUrl;
            ViewData["date6"] = _blogService.GetFirstBlogByCategory(6).Date;

            return View();
        }
    }
}
