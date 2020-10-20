using FluentValidation;
using RubiconAssignment.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Validators
{
    public class BlogPostUpdateValidator : AbstractValidator<BlogPostUpdateVM>
    {
        public BlogPostUpdateValidator()
        {
            RuleFor(x => x.Title)
                .MaximumLength(100)
                .WithMessage("Maximum length of title is 100.");

            RuleFor(x => x.Description)
                .MaximumLength(500)
                .WithMessage("Maximum length of post description is 500.");

            RuleFor(x => x.Body)
                .MaximumLength(2500)
                .WithMessage("Maximum length of post body is 2500.");
        }
    }
}
