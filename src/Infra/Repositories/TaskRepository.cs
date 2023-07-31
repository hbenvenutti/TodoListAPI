using TodoList.Infra.Repositories.Interfaces;
using TodoList.Models;

namespace TodoList.Infra.Repositories;

public class TaskRepository : ITaskRepository
{
    public TaskModel Create(TaskModel task)
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

    public TaskModel Update(TaskModel task)
    {
        throw new NotImplementedException();
    }
}
