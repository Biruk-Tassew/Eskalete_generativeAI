using TM.Domain;

namespace TM.Application;
public class TaskDTO : ITaskDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status status {get; set;}
}