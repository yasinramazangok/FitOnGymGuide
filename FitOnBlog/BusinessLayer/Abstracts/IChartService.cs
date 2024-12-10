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
        public BlogCategoryDataDto GetCategoryBlogCountAsync();

        public BlogCategoryDataDto GetBlogRatingAsync();
    }
}
