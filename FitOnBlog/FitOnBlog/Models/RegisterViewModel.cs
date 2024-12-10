using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FitOnBlog.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı girmelisiniz!")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Emailinizi girmelisiniz!")]
        [DataType(DataType.EmailAddress)]
        [StringLength(75)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi girmelisiniz!")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Şifrenizi tekrar girmelisiniz!")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string? ConfirmPassword { get; set; }

        [StringLength(75)]
        public string? PhoneNumber { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        [StringLength(500)]
        public string? About { get; set; }

        [StringLength(75)]
        public string? Title { get; set; }

        [StringLength(300)]
        public string? Expertises { get; set; }

        public string? Role { get; set; }

    }
}
