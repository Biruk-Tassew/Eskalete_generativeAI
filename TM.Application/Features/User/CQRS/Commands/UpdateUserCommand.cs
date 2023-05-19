using MediatR;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS.Commands
{
    public class UpdateUserCommand :IRequest<Result<Unit>>
    {
        public UpdateUserDto UpdateUserDto { get; set; }
        
    }
}