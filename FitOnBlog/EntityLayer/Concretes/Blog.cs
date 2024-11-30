using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }  

        [StringLength(150)]
        public string? Title { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        public DateTime Date { get; set; }

        public string? Content { get; set; }

        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
