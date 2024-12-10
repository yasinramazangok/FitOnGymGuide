using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class BlogCategoryDataDto
    {
        public List<string?>? Labels { get; set; }

        public List<BlogCategoryDatasetDto>? Datasets { get; set; }
    }
}
