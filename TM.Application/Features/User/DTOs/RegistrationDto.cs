namespace TM.Application.Features.User.DTOs
{
    public class RegistrationDto : IUserDto
    {
        public string UserName {get; set;}
        public string Email {get; set;}
        public string password {get; set;}
        
    }
}