namespace TodoList.Models;

public class TaskModel
{
    public required int Id { get; set; }
    
    public required string Title { get; set; }

    public required string Description { get; set; }

    public bool Status { get; set; } = false;

    public DateTime CreatedAt { get; set; }
}
