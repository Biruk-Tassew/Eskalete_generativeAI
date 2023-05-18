using MediatR;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Tasks.CQRS.Commands
{
    public class UpdateTasksCommand :IRequest<Result<Unit>>
    {
        public UpdateTasksDto UpdateTasksDto { get; set; }
        
    }
}