using TM.Application.Features.Common;

namespace TM.Application.Features.User.DTOs
{
    public class AuthenticationDto : IUserDto
    {
        
        public string UserName {get; set;}
        public string password {get; set;}
    }
}