using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;
using MediatR;


namespace TM.Application.Features.Tasks.CQRS.Handlers
{
    public class GetTasksDetailQueryHandler : IRequestHandler<GetTasksDetailQuery,Result<TasksDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTasksDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<TasksDto>> Handle(GetTasksDetailQuery request, CancellationToken cancellationToken)
        {
            var response = new Result<TasksDto>();
            var Tasks = await _unitOfWork.TasksRepository.Get(request.Id);
            response.Success = true;
            response.Message = "Fetch Success";
            response.Value = _mapper.Map<TasksDto>(Tasks);

            return response;
        }
    }
}
