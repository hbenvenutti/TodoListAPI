
using TodoList.Dtos.Tasks;
using TodoList.Models;

namespace TodoList.Providers.Mapper;

public interface IMapperProvider
{
    TaskModel Map(CreateTaskDto dto);

    TaskModel Map(UpdateTaskDto dto);

    ResponseTaskDto Map(TaskModel task);

    IEnumerable<ResponseTaskDto> Map(IEnumerable<TaskModel> tasks);
}
