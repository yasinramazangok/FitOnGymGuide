using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        [StringLength(200)]
        public string? ImageUrl1 { get; set; }

        [StringLength(200)]
        public string? ImageUrl2 { get; set; }

        [StringLength(1000)]
        public string? Content { get; set; }

        [StringLength(1000)]
        public string? Content1 { get; set; }
    }
}
