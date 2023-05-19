namespace TM.Application.Features.Tasks.DTOs
{
    public class UpdateUserDto : IUserDto
    {
        
        public string UserName {get; set;}
        public string Email {get; set;}
        public string password {get; set;}
        
    }
}