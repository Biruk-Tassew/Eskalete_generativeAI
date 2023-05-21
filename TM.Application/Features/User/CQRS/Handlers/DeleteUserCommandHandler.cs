using AutoMapper;
using TM.Application.Contracts.Persistence;
using TM.Application.Exceptions;
using TM.Application.Features.User.CQRS.Commands;
using TM.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Application.Features.User.CQRS.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand,Result<Unit>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<Unit>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var response = new Result<Unit>();
            var User = await _unitOfWork.UserRepository.Get(request.Id);

            if (User == null)
            {
                return null;
            }
            else
            {
                await _unitOfWork.UserRepository.Delete(User);
                if (await _unitOfWork.Save() > 0 )
                {
                    response.Success = true;
                    response.Message = "Delete Successful";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Delete Failed";
                }
            
            }
            return response;
        }
    }
}
