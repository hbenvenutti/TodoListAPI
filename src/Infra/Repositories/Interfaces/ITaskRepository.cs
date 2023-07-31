using TodoList.Models;

namespace TodoList.Infra.Repositories.Interfaces;

public interface ITaskRepository
{
    TaskModel Create(TaskModel task);

    void Delete(int id);

    TaskModel? FindById(int id);

    IEnumerable<TaskModel> List();

    TaskModel Update(TaskModel task);
}
