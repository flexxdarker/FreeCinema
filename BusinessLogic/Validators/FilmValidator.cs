using BusinessLogic.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class FilmValidator : AbstractValidator<FilmDto>
    {
        public FilmValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(5)
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter");
            RuleFor(x => x.Date)
                .NotEmpty()
                .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("Birthdate must be bigger that 1900")
                .LessThan(DateTime.Now).WithMessage("You from future?)");
            RuleFor(x => x.ImageUrl)
                .NotEmpty()
                .Must(LinkMustBeAUrl).WithMessage("{PropertyName} must be correct Url");
            RuleFor(x => x.Year)
                .NotEmpty();
            RuleFor(x => x.CategoryId)
                .NotEmpty();    
            RuleFor(x=>x.CompanyId)
                .NotEmpty();
        }
        private static bool LinkMustBeAUrl(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            //Courtesy of @Pure.Krome's comment and https://stackoverflow.com/a/25654227/563532
            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
