using MediatR;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Tasks.CQRS
{

   public class GetTasksDetailQuery :IRequest<Result<TasksDto>>
    {
        
        public int Id { get; set; }
    }
    
}