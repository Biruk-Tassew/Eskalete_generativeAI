namespace TM.Application.Features.Tasks.DTOs
{
    public class CreateTasksDto : ITasksDto
    {
         public string Title { get; set; }

        public int UserId { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}