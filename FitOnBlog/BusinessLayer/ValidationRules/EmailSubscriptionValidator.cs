using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EmailSubscriptionValidator : AbstractValidator<EmailSubscription>
    {
        public EmailSubscriptionValidator()
        {
            RuleFor(a => a.Email).NotEmpty();

            RuleFor(a => a.Email).MinimumLength(11);
            RuleFor(a => a.Email).MaximumLength(75);          
        }
    }
}
