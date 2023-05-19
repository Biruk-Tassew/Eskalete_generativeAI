using MediatR;
using TM.Application.Features.User.DTOs;
using TM.Application.Responses;

namespace TM.Application.Features.User.CQRS.Queries
{
    public class GetUserListQuery : IRequest<Result<List<UserDto>>>
    {
        
    }
}