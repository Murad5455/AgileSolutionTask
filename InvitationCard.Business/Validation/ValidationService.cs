
using FluentValidation;
using InvitationCard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvitationCard.Business.NewFolder
{
    public class ValidationService : AbstractValidator<Card>
    {
        public ValidationService()
        {
            RuleFor(u => u.FirstName).NotEmpty().NotNull().Length(0, 20);
            RuleFor(u => u.LastName).NotNull().NotEmpty().Length(0, 20);
            RuleFor(u => u.Title).NotEmpty().NotNull();
            RuleFor(u => u.CompanyName).NotEmpty().NotNull();
            RuleFor(u => u.Address).NotEmpty().NotNull();
            RuleFor(u => u.PhoneNumber).NotEmpty().NotNull().Length(10);
            RuleFor(u => u.Email).EmailAddress().NotNull().NotEmpty();
        }
    }
}
