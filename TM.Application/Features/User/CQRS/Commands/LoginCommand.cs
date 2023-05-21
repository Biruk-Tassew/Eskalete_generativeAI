using MediatR;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS.Commands
{
    public class LoginCommand : IRequest<Result<string>>
    {
        public AuthenticationDto authenticationDto { get; set; }

    }
}
