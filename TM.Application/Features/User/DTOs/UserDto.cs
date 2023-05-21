using TM.Application.Features.Common;

namespace TM.Application.Features.User.DTOs
{
    public class UserDto : IUserDto
    {
        public string UserName {get; set;}
        public string Email {get; set;}
    }
}