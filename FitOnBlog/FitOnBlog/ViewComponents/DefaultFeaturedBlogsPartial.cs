﻿using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    [AllowAnonymous]
    public class DefaultFeaturedBlogsPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public DefaultFeaturedBlogsPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
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

            ViewData["blogId1"] = _blogService.GetLastBlogByCategory(1).BlogId;
            ViewData["title1"] = _blogService.GetLastBlogByCategory(1).Title;
            ViewData["imageUrl1"] = _blogService.GetLastBlogByCategory(1).ImageUrl;
            ViewData["date1"] = _blogService.GetLastBlogByCategory(1).Date;

            ViewData["blogId2"] = _blogService.GetLastBlogByCategory(2).BlogId;
            ViewData["title2"] = _blogService.GetLastBlogByCategory(2).Title;
            ViewData["imageUrl2"] = _blogService.GetLastBlogByCategory(2).ImageUrl;
            ViewData["date2"] = _blogService.GetLastBlogByCategory(2).Date;

            ViewData["blogId3"] = _blogService.GetLastBlogByCategory(3).BlogId;
            ViewData["title3"] = _blogService.GetLastBlogByCategory(3).Title;
            ViewData["imageUrl3"] = _blogService.GetLastBlogByCategory(3).ImageUrl;
            ViewData["date3"] = _blogService.GetLastBlogByCategory(3).Date;
            //ViewData["category3"] = _blogService.GetLastBlogByCategory(3).Category;

            ViewData["blogId4"] = _blogService.GetLastBlogByCategory(4).BlogId;
            ViewData["title4"] = _blogService.GetLastBlogByCategory(4).Title;
            ViewData["imageUrl4"] = _blogService.GetLastBlogByCategory(4).ImageUrl;
            ViewData["date4"] = _blogService.GetLastBlogByCategory(4).Date;

            ViewData["blogId6"] = _blogService.GetLastBlogByCategory(6).BlogId;
            ViewData["title6"] = _blogService.GetLastBlogByCategory(6).Title;
            ViewData["imageUrl6"] = _blogService.GetLastBlogByCategory(6).ImageUrl;
            ViewData["date6"] = _blogService.GetLastBlogByCategory(6).Date;

            return View();
        }
    }
}
