using TM.Application.Features.Common;

namespace TM.Application.Features.Tasks.DTOs
{
    public class TasksDto : IUserDto
    {
        public string UserName {get; set;}
        public string Email {get; set;}
    }
}