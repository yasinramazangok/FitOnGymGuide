using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class EmailSubscription
    {
        [Key]
        public int EmailId { get; set; }

        [StringLength(75)]
        public string? Email { get; set; }
    }
}
