using BusinessLayer.Abstracts;
using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class ChartManager : IChartService
    {
        // See the comments where a method is defined to learn what it does 

        private readonly ICategoryService _categoryService;

        private readonly IBlogService _blogService;

        public ChartManager(ICategoryService categoryService, IBlogService blogService)
        {
            _categoryService = categoryService;

            _blogService = blogService;
        }

        public BlogCategoryDataDto GetBlogRatingAsync()
        {
            var blogRatings = _blogService.GetListAll();

            var randomColors = new Random();

            var chartData = new BlogCategoryDataDto
            {
                Labels = blogRatings.Select(c => c.Title).ToList(),
                Datasets = new List<BlogCategoryDatasetDto>
                {
                    new BlogCategoryDatasetDto
                    {
                        Data = blogRatings.Select(c => c.Rating).ToList(),
                        BackgroundColor = blogRatings
                    .Select(_ => $"#{randomColors.Next(0x1000000):X6}")
                    .ToList()

                    }
                }
            };

            return chartData;
        }

        public BlogCategoryDataDto GetCategoryBlogCountAsync()
        {
            var categoryBlogCounts = _categoryService.GetListAll();

            var randomColors = new Random();

            var chartData = new BlogCategoryDataDto
            {
                Labels = categoryBlogCounts.Select(c => c.Name).ToList(),
                Datasets = new List<BlogCategoryDatasetDto>
                {
                    new BlogCategoryDatasetDto
                    {
                        Data = categoryBlogCounts.Select(c => c.BlogCount).ToList(),
                        BackgroundColor = categoryBlogCounts
                    .Select(_ => $"#{randomColors.Next(0x1000000):X6}")
                    .ToList()
                    }
                }
            };

            return chartData;
        }
    }
}
