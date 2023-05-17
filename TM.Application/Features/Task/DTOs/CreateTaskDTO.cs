namespace TM.Application;
public class CreateTaskDTO: ITaskDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}