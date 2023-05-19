using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Exceptions;
using TM.Application.Features.User.CQRS.Commands;
using TM.Application.Features.User.DTOs.Validators;
using TM.Application.Responses;
using MediatR;

namespace TM.Application.Features.User.CQRS.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<Unit>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<Unit>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var response = new Result<Unit>();

            var validator = new UpdateUserDtoValidator();
            var validationResult = await validator.ValidateAsync(request.UpdateUserDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Update Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var tasks = await _unitOfWork.UserRepository.Get(request.UpdateUserDto.Id);

                if (tasks == null)
                    return null;
                   
                _mapper.Map(request.UpdateUserDto, tasks);

                await _unitOfWork.UserRepository.Update(tasks);
              
                if (await _unitOfWork.Save() > 0)
                {
                    response.Success = true;
                    response.Message = "Updated Successful";
                    
                }
                else
                {
                    response.Success = false;
                    response.Message = "Update Failed";
                }    
            }

            return response;
        }
    }
}
