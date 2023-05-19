using FluentValidation;

namespace TM.Application.Features.Tasks.DTOs.Validators
{
    public class RegistrationDtoValidator : AbstractValidator<RegistrationDto>
    {
        public RegistrationDtoValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Email)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(200).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Password)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .MinimumLength(8).WithMessage("{PropertyName} must be at least 8 characters long.")
               .Matches("[A-Z]").WithMessage("{PropertyName} must contain at least one uppercase letter.")
               .Matches("[a-z]").WithMessage("{PropertyName} must contain at least one lowercase letter.")
               .Matches("[0-9]").WithMessage("{PropertyName} must contain at least one digit.")
               .Matches("[^a-zA-Z0-9]").WithMessage("{PropertyName} must contain at least one special character.");
        }
    }
}