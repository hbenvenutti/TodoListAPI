namespace TodoList.Dtos.Tasks;

public class CreateTaskDto
{
    public required string Title { get; init; }

    public required string Description { get; init; }

    public bool? Status { get; init; }
}
