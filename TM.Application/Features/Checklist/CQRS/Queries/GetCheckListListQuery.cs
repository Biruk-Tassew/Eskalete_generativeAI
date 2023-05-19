using MediatR;
using TM.Application.Features.Checklist.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.Checklist.CQRS.Queries
{
    public class GetCheckListListQuery : IRequest<Result<List<CheckListDto>>>
    {
        
    }
}