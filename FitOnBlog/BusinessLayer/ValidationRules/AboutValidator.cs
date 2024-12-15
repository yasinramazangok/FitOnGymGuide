using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(a => a.ImageUrl).NotEmpty().WithMessage("Resim 1'i boş geçemezsiniz!");
            RuleFor(a => a.ImageUrl1).NotEmpty().WithMessage("Resim 2'yi boş geçemezsiniz!");
            RuleFor(a => a.ImageUrl2).NotEmpty().WithMessage("Resim 3'ü boş geçemezsiniz!");
            RuleFor(a => a.Content).NotEmpty().WithMessage("İçeriği 1'i boş geçemezsiniz!");
            RuleFor(a => a.Content1).NotEmpty().WithMessage("İçerik 2'yi boş geçemezsiniz!");

            RuleFor(a => a.ImageUrl).MinimumLength(5).WithMessage("Resim 1 minimum 5 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl).MaximumLength(200).WithMessage("Resim 1 maksimum 200 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl1).MinimumLength(5).WithMessage("Resim 2 minimum 5 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl1).MaximumLength(200).WithMessage("Resim 2 maksimum 200 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl2).MinimumLength(5).WithMessage("Resim 3 minimum 5 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl2).MaximumLength(200).WithMessage("Resim 3 maksimum 200 karakter olmalıdır!");
            RuleFor(a => a.Content).MinimumLength(5).WithMessage("İçerik 1 minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Content).MaximumLength(1000).WithMessage("İçerik 1 maksimum 1000 karakter olmalıdır!");
            RuleFor(a => a.Content1).MinimumLength(5).WithMessage("İçerik 2 minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Content1).MaximumLength(1000).WithMessage("İçerik 2 maksimum 1000 karakter olmalıdır!");
        }
    }
}
