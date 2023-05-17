using System;
using MediatR;

namespace TM.Application.Features.Task.CQRS.Queries;
public class GetTaskDetailQuery : IRequest<TaskDTO>
{
    public string Id { get; set; }
}

