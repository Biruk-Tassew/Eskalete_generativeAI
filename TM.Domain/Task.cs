using System;
using Microsoft.AspNetCore.Identity;
using TM.Domain.Common;

namespace TM.Domain;
public class Tasks : BaseModel
{   
    public string OwnerId {get; set;}
    public IdentityUser Owner { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }

    public Tasks()
    {
        Status = Status.NotStarted;
    }
}

public enum Status
{
    NotStarted,
    InProgress,
    Status
}