using System.ComponentModel.DataAnnotations;

namespace FitOnBlog.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email adresinizi girmelisiniz!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifrenizi girmelisiniz!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }

        [Required(ErrorMessage = "Kullanıcı türü seçmelisiniz!")]
        public string? Role { get; set; }

    }
}
