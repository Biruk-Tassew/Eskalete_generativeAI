using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Features.User.DTOs;
using TM.Application.Features.User.CQRS.Queries;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Application.Features.User.CQRS.Handlers
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, Result<List<UserDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<List<UserDto>>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {

            var response = new Result<List<UserDto>>();
            var User = await _unitOfWork.UserRepository.GetAll();
       
            response.Success = true;
            response.Message = "Fetch Success";
            response.Value = _mapper.Map<List<UserDto>>(User);

            return response;
        }
    }
}
