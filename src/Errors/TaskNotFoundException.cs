namespace TodoList.Errors;

public class TaskNotFoundException : NotFoundException
{
    private static readonly string _message = "Task not found";

    public TaskNotFoundException() : base(_message) {}
}
