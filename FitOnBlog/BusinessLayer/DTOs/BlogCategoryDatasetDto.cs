using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class BlogCategoryDatasetDto
    {
        public List<int?>? Data { get; set; } // for Category.BlogCount or Blog.Rating column
        public List<string>? BackgroundColor { get; set; } // for Category colors
    }
}
