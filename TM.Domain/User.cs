using System;
using Microsoft.AspNetCore.Identity;


namespace TM.Domain;
public class Task : BaseModel
{   
    public string OwnerId {get; set;}
    public IdentityUser Owner { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }
}

public enum Status
{
    NotStarted,
    InProgress,
    Completed
}