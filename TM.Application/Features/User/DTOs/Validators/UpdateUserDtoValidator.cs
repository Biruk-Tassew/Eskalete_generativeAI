using FluentValidation;

namespace TM.Application.Features.User.DTOs.Validators
{
    public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
    {

        public UpdateUserDtoValidator()
        {
            Include(new IUserDtoValidator());
        }
        
    }
}