using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(a => a.Title).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz!");
            RuleFor(a => a.ImageUrl).NotEmpty().WithMessage("Resim yolunu boş geçemezsiniz!");
            RuleFor(a => a.Content).NotEmpty().WithMessage("İçeriği boş geçemezsiniz!");
            RuleFor(a => a.Date).NotEmpty().WithMessage("Tarih seçimi yapmalısınız!");
            RuleFor(a => a.AuthorId).NotEmpty().WithMessage("Yazar seçimi yapmalısınız!");
            RuleFor(a => a.CategoryId).NotEmpty().WithMessage("Kategori seçimi yapmalısınız!");

            RuleFor(a => a.Title).MinimumLength(5).WithMessage("Blog başlığı minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Title).MaximumLength(150).WithMessage("Blog başlığı maksimum 150 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl).MinimumLength(5).WithMessage("Resim yolu minimum 5 karakter olmalıdır!");
            RuleFor(a => a.ImageUrl).MaximumLength(200).WithMessage("Resim yolu maksimum 200 karakter olmalıdır!");
            RuleFor(a => a.Content).MinimumLength(150).WithMessage("Blog yazısı minimum 150 karakter olmalıdır!");
        }
    }
}
