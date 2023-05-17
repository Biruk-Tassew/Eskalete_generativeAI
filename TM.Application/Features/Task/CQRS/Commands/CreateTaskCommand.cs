
using MediatR;
using TM.Application;

namespace TM.Application.Features.Task.CQRS.Commands;
public class CreateTaskCommand : IRequest<Result<int>>
{
    public CreateTaskDTO Task { get; set; }
}