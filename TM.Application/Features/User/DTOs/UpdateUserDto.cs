namespace TM.Application.Features.User.DTOs
{
    public class UpdateUserDto : IUserDto
    {
        public string Id {get; set;}
        public string UserName {get; set;}
        public string Email {get; set;}
        public string password {get; set;}
        
    }
}