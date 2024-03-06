using BusinessLogic.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class SessionValidator : AbstractValidator<Session>
    {
        public SessionValidator() 
        {
            RuleFor(x => x.DateTime)
                .NotEmpty()
                .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("Birthdate must be bigger that 1900")
                .LessThan(DateTime.Now).WithMessage("You from future?)");

        }

    }
}
