using MediatR;
using TM.Application.Responses;

namespace TM.Application.Features.Tasks.CQRS.Commands
{
    public class DeleteTasksCommand : IRequest<Result<Unit>>
    {
        
        public int Id { get; set; }

    }
}