using MediatR;
using TM.Application;

namespace TM.Application.Features.Task.CQRS.Commands;
public class DeleteTaskCommand : IRequest<Result<Unit>>
{
    public int Id { get; set; }
}