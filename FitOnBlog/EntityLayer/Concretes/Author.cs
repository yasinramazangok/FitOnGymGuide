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
        [Key]
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(75)]
        public string? Email { get; set; }

        [StringLength(25)]
        public string? PhoneNumber { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        public string? Password { get; set; }

        [StringLength(500)]
        public string? About { get; set; }

        [StringLength(75)]
        public string? Title { get; set; }

        [StringLength(300)]
        public string? Expertises { get; set; }
        
        public ICollection<Blog>? Blogs { get; set; }
    }
}
