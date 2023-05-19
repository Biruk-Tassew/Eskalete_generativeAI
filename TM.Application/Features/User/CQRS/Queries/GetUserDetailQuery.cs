using MediatR;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS
{

   public class GetUserDetailQuery :IRequest<Result<UserDto>>
    {
        
        public int Id { get; set; }
    }
    
}