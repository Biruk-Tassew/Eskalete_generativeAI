using MediatR;
using TM.Application.Responses;

namespace TM.Application.Features.Checklist.CQRS.Commands
{
    public class DeleteCheckListCommand : IRequest<Result<Unit>>
    {

        public int Id { get; set; }
        
    }
}