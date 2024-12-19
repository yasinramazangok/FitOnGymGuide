using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IChartService
    {
        // for Chart 
        public BlogCategoryDataDto GetCategoryBlogCountAsync();

        // for Chart
        public BlogCategoryDataDto GetBlogRatingAsync();
    }
}
