using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Author
    {
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        [StringLength(30)]
        public string? PhoneNumber { get; set; }

        [StringLength(300)]
        public string? About { get; set; }

        public ICollection<Blog>? Blogs { get; set; }
    }
}
