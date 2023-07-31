using TodoList.Dtos.Tasks;
using TodoList.Services.Interfaces;
using TodoList.Models;

namespace TodoList.Services;

public class TaskService : ITaskService
{

    // *** --- methods -------------------------------------------------- *** //

    public TaskModel Create(CreateTaskDto dto)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public TaskModel? FindById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TaskModel> List()
    {
        throw new NotImplementedException();
    }

    public TaskModel Update(UpdateTaskDto dto)
    {
        throw new NotImplementedException();
    }
}
