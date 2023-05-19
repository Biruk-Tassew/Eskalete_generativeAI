using MediatR;
using TM.Application.Features.Checklist.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Checklist.CQRS.Commands
{
    public class CreateCheckListCommand : IRequest<Result<int>>
    {
        public CreateCheckListDto CreateCheckListDto { get; set; }
    }
}