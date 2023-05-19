using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Features.Tasks.CQRS.Queries;
using TM.Application.Features.Tasks.DTOs;
using TM.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Application.Features.Tasks.CQRS.Handlers
{
    public class GetTasksListQueryHandler : IRequestHandler<GetTasksListQuery, Result<List<TasksDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTasksListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<List<TasksDto>>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
        {

            var response = new Result<List<TasksDto>>();
            var Tasks = await _unitOfWork.TasksRepository.GetAll();
       
            response.Success = true;
            response.Message = "Fetch Success";
            response.Value = _mapper.Map<List<TasksDto>>(Tasks);

            return response;
        }
    }
}
