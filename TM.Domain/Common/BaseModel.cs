using System;

namespace TM.Domain.Common;
public class BaseModel
{
    public int Id {get; set;}
    public readonly DateTime CreatedDate = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
}