namespace TaskManager.Core.Models;

public class TaskEntity
{
    public Guid Id { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public TaskStatus Status { get; set; }
}