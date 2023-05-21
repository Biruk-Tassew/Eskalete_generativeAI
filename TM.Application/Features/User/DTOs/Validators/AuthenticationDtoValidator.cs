using FluentValidation;

namespace TM.Application.Features.User.DTOs.Validators
{
    public class AuthenticationDtoValidator : AbstractValidator<AuthenticationDto>
    {

        public AuthenticationDtoValidator()
        {

            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.password)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(200).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
}
        
    }
}