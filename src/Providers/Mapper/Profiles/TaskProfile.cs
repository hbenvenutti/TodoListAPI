using AutoMapper;
using TodoList.Dtos.Tasks;
using TodoList.Models;

namespace TodoList.Providers.Mapper.Profiles;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<CreateTaskDto, TaskModel>().ReverseMap();
        CreateMap<UpdateTaskDto, TaskModel>().ReverseMap();
        CreateMap<TaskModel, ResponseTaskDto>();
        // CreateMap<IEnumerable<TaskModel>, IEnumerable<ResponseTaskDto>>();
    }    
}
