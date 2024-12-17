using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(a => a.Email).NotEmpty().WithMessage("Email'i boş geçemezsiniz!");
            RuleFor(a => a.PhoneNumber).NotEmpty().WithMessage("Telefon numarasını boş geçemezsiniz!");
            RuleFor(a => a.ImageUrl).NotEmpty().WithMessage("Resim yolunu boş geçemezsiniz!");
            RuleFor(a => a.Password).NotEmpty().WithMessage("Şifreyi boş geçemezsiniz!");
            RuleFor(a => a.About).NotEmpty().WithMessage("Hakkında bilgisini boş geçemezsiniz!");
            RuleFor(a => a.Title).NotEmpty().WithMessage("Meslek bilgisini boş geçemezsiniz!");
            RuleFor(a => a.Expertises).NotEmpty().WithMessage("Uzmanlık alanlarını boş geçemezsiniz!");

            RuleFor(a => a.Name).MinimumLength(5).WithMessage("Yazar adı minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Name).MaximumLength(50).WithMessage("Yazar adı maksimum 50 karakter olmalıdır!");
            RuleFor(a => a.Email).MinimumLength(11).WithMessage("Email minimum 11 karakter olmalıdır!");
            RuleFor(a => a.Email).MaximumLength(75).WithMessage("Email maksimum 75 karakter olmalıdır!");
            RuleFor(a => a.PhoneNumber).MinimumLength(11).WithMessage("Telefon numarası minimum 11 karakter olmalıdır!");
            RuleFor(a => a.PhoneNumber).MaximumLength(25).WithMessage("Telefon numarası maksimum 25 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl).MinimumLength(5).WithMessage("Resim yolu minimum 5 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl).MaximumLength(200).WithMessage("Resim yolu maksimum 200 karakter olmalıdır!");
            RuleFor(a => a.Password).MinimumLength(8).WithMessage("Şifre minimum 8 karakter olmalıdır!");
            RuleFor(a => a.Password).MaximumLength(50).WithMessage("Şifre maksimum 50 karakter olmalıdır!");
            RuleFor(a => a.About).MinimumLength(50).WithMessage("Hakkında bilgisi minimum 50 karakter olmalıdır!");
            RuleFor(a => a.About).MaximumLength(500).WithMessage("Hakkında bilgisi maksimum 500 karakter olmalıdır!");
            RuleFor(a => a.Title).MinimumLength(5).WithMessage("Meslek bilgisi minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Title).MaximumLength(75).WithMessage("Meslek bilgisi maksimum 75 karakter olmalıdır!");
            RuleFor(a => a.Expertises).MinimumLength(5).WithMessage("Uzmanlık alanları minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Expertises).MaximumLength(300).WithMessage("Uzmanlık alanları maksimum 300 karakter olmalıdır!");
        }
    }
}
