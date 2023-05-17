namespace TM.Domain;
public class CheckList: BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string TaskId { get; set; }
    public Task Task {get; set;}
    public Status Status { get; set; }
}

