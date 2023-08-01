using AutoMapper;
using TodoList.Dtos.Tasks;
using TodoList.Models;

namespace TodoList.Providers.Mapper;

public class Mapper : IMapperProvider
{
    private readonly IMapper _mapper;

    // *** --- constructors --------------------------------------------- *** //

    public Mapper(IMapper mapper)
    {
        _mapper = mapper;

        return;
    }

    // *** --- public methods ------------------------------------------- *** //

    public TaskModel Map(CreateTaskDto dto) => _mapper.Map<TaskModel>(dto);

    public TaskModel Map(UpdateTaskDto dto) => _mapper.Map<TaskModel>(dto);

    public ResponseTaskDto Map(TaskModel task) => 
        _mapper.Map<ResponseTaskDto>(task);

    public IEnumerable<ResponseTaskDto> Map(IEnumerable<TaskModel> tasks) =>
        _mapper.Map<IEnumerable<ResponseTaskDto>>(tasks);
}
