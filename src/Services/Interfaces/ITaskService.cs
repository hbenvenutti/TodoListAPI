using TodoList.Dtos.Tasks;
using TodoList.Models;

namespace TodoList.Services.Interfaces;

public interface ITaskService
{
    IEnumerable<ResponseTaskDto> List();

    ResponseTaskDto? FindById(int id);

    ResponseTaskDto Create(CreateTaskDto dto);

    ResponseTaskDto Update(int id, UpdateTaskDto dto);

    void Delete(int id);
}
