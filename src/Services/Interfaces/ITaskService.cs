using TodoList.Dtos.Tasks;
using TodoList.Models;

namespace TodoList.Services.Interfaces;

public interface ITaskService
{
    IEnumerable<TaskModel> List();

    TaskModel? FindById(int id);

    TaskModel Create(CreateTaskDto dto);

    TaskModel Update(UpdateTaskDto dto);

    void Delete(int id);
}
