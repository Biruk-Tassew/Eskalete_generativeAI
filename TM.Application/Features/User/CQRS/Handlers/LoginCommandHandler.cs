using MediatR;
using TM.Application.Contracts.Persistence;
using TM.Application.Features.User.CQRS.Commands;
using TM.Application.Responses;
using System.Threading;
using System.Threading.Tasks;
using TM.Application.Features.User.DTOs.Validators;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace TM.Application.Features.User.CQRS.Handlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LoginCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = new Result<string>();
            var validator = new AuthenticationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.authenticationDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Validation Error";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {

                var user = _mapper.Map<IdentityUser>(request.authenticationDto);

                var loggedInUser = await _unitOfWork.UserRepository.Login(user);
                if (await _unitOfWork.Save() > 0)
                {
                    response.Success = true;
                    response.Message = "Login Successful";
                    response.Value = loggedInUser.Id;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Login Failed";
                }
            }
            return response;
        }
    }
}
