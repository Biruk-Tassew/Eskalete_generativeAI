using MediatR;
using TM.Application.Features.Checklist.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Checklist.CQRS.Commands
{
    public class UpdateCheckListCommand : IRequest<Result<Unit>>
    {

        public UpdateCheckListDto UpdateCheckListDto { get; set; }
        
    }
}