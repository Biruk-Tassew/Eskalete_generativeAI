using FluentValidation;

namespace TM.Application.Features.User.DTOs.Validators
{
    public class IUserDtoValidator : AbstractValidator<UpdateUserDto>
    {
        public IUserDtoValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

        }
    }
}