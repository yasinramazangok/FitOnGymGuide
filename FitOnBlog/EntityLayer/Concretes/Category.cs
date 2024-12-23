﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public int? BlogCount { get; set; }

        public ICollection<Blog>? Blogs { get; set; }
    }
}
