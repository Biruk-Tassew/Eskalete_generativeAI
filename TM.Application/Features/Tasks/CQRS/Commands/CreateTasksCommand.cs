using MediatR;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Tasks.CQRS.Commands
{
    public class CreateTasksCommand : IRequest<Result<int>>
    {
        public CreateTasksDto CreateTasksDto { get; set; }
        
    }
}