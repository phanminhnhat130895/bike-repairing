using FluentValidation;

namespace Application.Features.RequestFeatures
{
    public sealed class CreateRequestValidator : AbstractValidator<CreateRequestRequest>
    {
        public CreateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.")
                                .MaximumLength(100).WithMessage("Maximum length of name is 100 characters.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty.")
                                 .MaximumLength(100).WithMessage("Maximum length of email is 100 characters.")
                                 .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty.");
        }
    }
}
