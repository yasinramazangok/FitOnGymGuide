using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using FitOnBlog.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Extensions;
using X.PagedList.Mvc;
using X.PagedList.Mvc.Core;

namespace FitOnBlog.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IBlogService _blogService;

        public DefaultController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index(int page = 1)
        {
            var blogList = _blogService.GetListAll().ToPagedList(page, 6);

            /* 
            ViewData["title1"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 1).Select(t => t.Title).FirstOrDefault();
            ViewData["imageUrl1"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 1).Select(t => t.ImageUrl).FirstOrDefault();
            ViewData["date1"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 1).Select(t => t.Date).FirstOrDefault();

            ViewData["title2"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 2).Select(t => t.Title).FirstOrDefault();
            ViewData["imageUrl2"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 2).Select(t => t.ImageUrl).FirstOrDefault();
            ViewData["date2"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 2).Select(t => t.Date).FirstOrDefault();

            ViewData["title3"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 3).Select(t => t.Title).FirstOrDefault();
            ViewData["imageUrl3"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 3).Select(t => t.ImageUrl).FirstOrDefault();
            ViewData["date3"] = _blogService.GetListAll().OrderByDescending(b => b.BlogId).Where(c => c.CategoryId == 3).Select(t => t.Date).FirstOrDefault();

            ViewData["title4"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 4).Select(t => t.Title).FirstOrDefault();
            ViewData["imageUrl4"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 4).Select(t => t.ImageUrl).FirstOrDefault();
            ViewData["date4"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 4).Select(t => t.Date).FirstOrDefault();

            ViewData["title6"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 6).Select(t => t.Title).FirstOrDefault();
            ViewData["imageUrl6"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 6).Select(t => t.ImageUrl).FirstOrDefault();
            ViewData["date6"] = _blogService.GetListAll().OrderBy(b => b.BlogId).Where(c => c.CategoryId == 6).Select(t => t.Date).FirstOrDefault();
            */

            ViewData["title1"] = _blogService.GetLastBlogByCategory(1).Title;
            ViewData["imageUrl1"] = _blogService.GetLastBlogByCategory(1).ImageUrl;
            ViewData["date1"] = _blogService.GetLastBlogByCategory(1).Date;

            ViewData["title2"] = _blogService.GetFirstBlogByCategory(2).Title;
            ViewData["imageUrl2"] = _blogService.GetFirstBlogByCategory(2).ImageUrl;
            ViewData["date2"] = _blogService.GetFirstBlogByCategory(2).Date;

            ViewData["title3"] = _blogService.GetLastBlogByCategory(3).Title;
            ViewData["imageUrl3"] = _blogService.GetLastBlogByCategory(3).ImageUrl;
            ViewData["date3"] = _blogService.GetLastBlogByCategory(3).Date;
            //ViewData["category3"] = _blogService.GetFirstBlogByCategory(3).Category;

            ViewData["title4"] = _blogService.GetLastBlogByCategory(4).Title;
            ViewData["imageUrl4"] = _blogService.GetLastBlogByCategory(4).ImageUrl;
            ViewData["date4"] = _blogService.GetLastBlogByCategory(4).Date;

            ViewData["title6"] = _blogService.GetFirstBlogByCategory(6).Title;
            ViewData["imageUrl6"] = _blogService.GetFirstBlogByCategory(6).ImageUrl;
            ViewData["date6"] = _blogService.GetFirstBlogByCategory(6).Date;

            return View(blogList);
        }

        public IActionResult FeaturedPosts()
        {

            return View();
        }

        public IActionResult RecentPosts()
        {
            return View();
        }

        public IActionResult OtherFeaturedPosts()
        {
            return View();
        }
    }
}
