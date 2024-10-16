using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [StringLength(300)]
        public string CommentText { get; set; }

        public int BlogID { get; set; }

        public virtual Blog? Blogs { get; set; }
    }
}
