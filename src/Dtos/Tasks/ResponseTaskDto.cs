namespace TodoList.Dtos.Tasks;

public class ResponseTaskDto
{
    public required int Id { get; set; }
    
    public required string Title { get; set; }

    public required string Description { get; set; }

    public bool Status { get; init; }

    public DateTime CreatedAt { get; init; }
}
