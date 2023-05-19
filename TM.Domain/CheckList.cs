using TM.Domain.Common;
namespace TM.Domain;
public class CheckList: BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int TaskId { get; set; }
    public Tasks Task {get; set;}
    public Status Status { get; set; }
    public CheckList()
    {
        Status = Status.NotStarted;
    }
}

