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
            ViewData["blogId2"] = _blogService.GetFirstBlogByCategory(15).BlogId;
            ViewData["title2"] = _blogService.GetFirstBlogByCategory(15).Title;
            ViewData["imageUrl2"] = _blogService.GetFirstBlogByCategory(15).ImageUrl;
            ViewData["date2"] = _blogService.GetFirstBlogByCategory(15).Date;

            ViewData["blogId5"] = _blogService.GetFirstBlogByCategory(17).BlogId;
            ViewData["title5"] = _blogService.GetFirstBlogByCategory(17).Title;
            ViewData["imageUrl5"] = _blogService.GetFirstBlogByCategory(17).ImageUrl;
            ViewData["date5"] = _blogService.GetFirstBlogByCategory(17).Date;

            ViewData["blogId3"] = _blogService.GetFirstBlogByCategory(13).BlogId;
            ViewData["title3"] = _blogService.GetFirstBlogByCategory(13).Title;
            ViewData["imageUrl3"] = _blogService.GetFirstBlogByCategory(13).ImageUrl;
            ViewData["date3"] = _blogService.GetFirstBlogByCategory(13).Date;

            ViewData["blogId6"] = _blogService.GetFirstBlogByCategory(16).BlogId;
            ViewData["title6"] = _blogService.GetFirstBlogByCategory(16).Title;
            ViewData["imageUrl6"] = _blogService.GetFirstBlogByCategory(16).ImageUrl;
            ViewData["date6"] = _blogService.GetFirstBlogByCategory(16).Date;

            return View();
        }
    }
}
