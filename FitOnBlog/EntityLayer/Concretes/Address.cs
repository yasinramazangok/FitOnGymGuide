using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [StringLength(75)]
        public string? Email { get; set; }

        [StringLength(25)]
        public string? PhoneNumber { get; set; }

        [StringLength(25)]
        public string? PhoneNumber1 { get; set; }

        [StringLength(200)]
        public string? Country { get; set; }

        [StringLength(200)]
        public string? City { get; set; }

        [StringLength(200)]
        public string? District { get; set; }

        [StringLength(200)]
        public string? Neighbourhood { get; set; }

        [StringLength(200)]
        public string? Avenue { get; set; }

        [StringLength(200)]
        public string? Street { get; set; }

        [StringLength(10)]
        public string? BuildingNumber { get; set; }

        [StringLength(200)]
        public string? Apartment { get; set; }

        [StringLength(5)]
        public string? Floor { get; set; }

        [StringLength(10)]
        public string? DoorNumber { get; set; }

        [StringLength(25)]
        public string? PostalCode { get; set; }
     
        [StringLength(500)]
        public string? MapInformation { get; set; }
    }
}
