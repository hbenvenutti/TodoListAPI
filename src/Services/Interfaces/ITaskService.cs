using TodoList.Dtos.Tasks;

namespace TodoList.Services.Interfaces;

public interface ITaskService
{
    IEnumerable<Task> List();

    Task? FindById(int id);

    Task Create(CreateTaskDto dto);

    Task Update(Task task);

    void Delete(int id);
}
