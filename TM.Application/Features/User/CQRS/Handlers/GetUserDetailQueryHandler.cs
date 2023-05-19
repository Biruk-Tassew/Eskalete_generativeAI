using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;
using MediatR;


namespace TM.Application.Features.User.CQRS.Handlers
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery,Result<UserDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<UserDto>> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var response = new Result<UserDto>();
            var User = await _unitOfWork.UserRepository.Get(request.Id);
            response.Success = true;
            response.Message = "Fetch Success";
            response.Value = _mapper.Map<UserDto>(User);

            return response;
        }
    }
}
