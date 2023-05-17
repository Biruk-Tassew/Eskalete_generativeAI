using MediatR;
using TM.Application;

namespace TM.Application.Features.Task.CQRS.Commands;
public class UpdateTaskCommand : IRequest<Result<Unit>>
{
    public UpdateTaskDTO Task { get; set; }
}