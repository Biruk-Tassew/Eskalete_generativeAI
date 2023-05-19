using MediatR;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS.Commands
{
    public class CreateUserCommand : IRequest<Result<int>>
    {
        public CreateUserCommand RegistrationDto { get; set; }
        
    }
}