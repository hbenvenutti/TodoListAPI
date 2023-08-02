using TodoList.Dtos.Tasks;
using TodoList.Services.Interfaces;
using TodoList.Models;
using TodoList.Infra.Repositories.Interfaces;
using TodoList.Providers.Mapper;
using TodoList.Errors;

// * ---------------------------------------------------------------------- * //

namespace TodoList.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;
    private readonly IMapperProvider _mapper;

    // *** --- constructors --------------------------------------------- *** //

    public TaskService(ITaskRepository repository, IMapperProvider mapper)
    {
        _repository = repository;
        _mapper = mapper;

        return;
    }

    // *** --- public methods ------------------------------------------- *** //

    public ResponseTaskDto Create(CreateTaskDto dto)
    {
        TaskModel task = _mapper.Map(dto);

        task = _repository.Create(task);

        return _mapper.Map(task);
    }

    // ---------------------------------------------------------------------- //

    public void Delete(int id)
    {
        var task = _repository.FindById(id) 
            ?? throw new TaskNotFoundException();
        
        _repository.Delete(task);

        return;
    }

    // ---------------------------------------------------------------------- //

    public ResponseTaskDto? FindById(int id)
    {
        var task = _repository.FindById(id)
            ?? throw new TaskNotFoundException();
        
        return _mapper.Map(task);
    }

    // ---------------------------------------------------------------------- //

    public IEnumerable<ResponseTaskDto> List()
    {
        var tasks = _repository.List();

        return _mapper.Map(tasks);
    }

    // ---------------------------------------------------------------------- //

    public ResponseTaskDto Update(int id, UpdateTaskDto dto)
    {
        var task = _repository.FindById(id);

        if (task is null)
        {
            task = _repository.Create(_mapper.Map(dto));

            return _mapper.Map(task);
        }

        _mapper.Map(dto, task);

        _repository.Update(task);
        
        return _mapper.Map(task);
    }
}
