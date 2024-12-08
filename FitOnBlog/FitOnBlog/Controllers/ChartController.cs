using BusinessLayer.Abstracts;
using FitOnBlog.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FitOnBlog.Controllers
{
    public class ChartController : Controller
    {
        private readonly IChartService _chartService;

        public ChartController(IChartService chartService)
        {
            _chartService = chartService;
        }

        public IActionResult CategoryBlogCount()
        {
            return View();
        }

        public IActionResult BlogRating()
        {
            return View();
        }

        public IActionResult CategoryBlogCountsInCharts()
        {
            var categoryBlogCounts = _chartService.GetCategoryBlogCountAsync();
     
            return Json(categoryBlogCounts);
        }

        public IActionResult BlogRatingsInCharts()
        {
            var blogRatings = _chartService.GetBlogRatingAsync();
         
            return Json(blogRatings);
        }
    }
}
