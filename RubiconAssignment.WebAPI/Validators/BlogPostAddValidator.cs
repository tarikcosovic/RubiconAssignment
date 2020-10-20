using FluentValidation;
using RubiconAssignment.WebAPI.ViewModels;

namespace RubiconAssignment.WebAPI.Validators
{
    public class BlogPostAddValidator : AbstractValidator<BlogPostAddVM>
    {
        public BlogPostAddValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title Must Not Be Empty.")
                .MaximumLength(100);

            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(500)
                .WithMessage("Maximum length of post description is 500.");

            RuleFor(x => x.Body)
                .NotEmpty()
                .MaximumLength(2500)
                .WithMessage("Maximum length of post body is 2500.");
        }
    }
}
