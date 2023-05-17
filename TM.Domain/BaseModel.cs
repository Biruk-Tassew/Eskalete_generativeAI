namespace TM.Domain;
public class BaseModel
{
    public string Id {get; set;}
    public readonly DateTime CreatedDate = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
}