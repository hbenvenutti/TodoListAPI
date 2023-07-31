using TodoList.Dtos.Tasks;
using TodoList.Services.Interfaces;

namespace TodoList.Services;

public class TaskService : ITaskService
{
    public Task Create(CreateTaskDto dto)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task? FindById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Task> List()
    {
        throw new NotImplementedException();
    }

    public Task Update(Task task)
    {
        throw new NotImplementedException();
    }
}
