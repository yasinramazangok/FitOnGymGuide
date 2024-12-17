using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz!");

            RuleFor(a => a.Name).MinimumLength(5).WithMessage("Kategori adı minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Name).MaximumLength(50).WithMessage("Kategori adı maksimum 50 karakter olmalıdır!");
            RuleFor(a => a.Description).MinimumLength(5).WithMessage("Kategori açıklaması minimum 5 karakter olmalıdır!");
            RuleFor(a => a.Description).MaximumLength(500).WithMessage("Kategori açıklaması maksimum 500 karakter olmalıdır!");
        }
    }
}
