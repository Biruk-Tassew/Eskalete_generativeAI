using MediatR;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Tasks.CQRS.Queries
{
    public class GetTasksListQuery : IRequest<Result<List<TasksDto>>>
    {
        
    }
}