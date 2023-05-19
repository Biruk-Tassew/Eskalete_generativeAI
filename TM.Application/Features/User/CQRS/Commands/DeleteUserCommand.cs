using MediatR;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS.Commands
{
    public class DeleteUserCommand : IRequest<Result<Unit>>
    {
        
        public int Id { get; set; }

    }
}