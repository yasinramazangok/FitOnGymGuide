using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(30)]
        public string? PhoneNumber { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
