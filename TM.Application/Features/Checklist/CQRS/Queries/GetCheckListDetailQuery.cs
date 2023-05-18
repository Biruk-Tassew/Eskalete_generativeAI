using MediatR;
using TM.Application.Features.Checklist.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Checklist.CQRS.Queries
{
    public class GetCheckListDetailQuery : IRequest<Result<CheckListDto>>
    {
        public int Id { get; set; }
        
    }
}