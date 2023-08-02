using Microsoft.AspNetCore.Mvc;
using TodoList.Dtos.Tasks;
using TodoList.Errors;
using TodoList.Services.Interfaces;

// * ---------------------------------------------------------------------- * //

namespace TodoList.Controllers;

[ApiController]
[Route("tasks")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    // *** --- constructors --------------------------------------------- *** //

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    // *** --- routes --------------------------------------------------- *** //

    [HttpGet]
    public IActionResult List()
    {
        return Ok(_taskService.List());
    }

    // ---------------------------------------------------------------------- //

    [HttpGet("{id}")]
    public IActionResult FindById(int id)
    {
        try 
        {
            var task = _taskService.FindById(id);

            return Ok(task);
        }

        catch (Exception e)
        {
            if (e is NotFoundException) return NotFound(e.Message);

            return Problem();
        }
    }

    // ---------------------------------------------------------------------- //

    [HttpPost]
    public IActionResult Create([FromBody] CreateTaskDto dto)
    {
        try
        {
            var task = _taskService.Create(dto);

            return CreatedAtAction(nameof(FindById), new { id = task.Id }, task);
        }

        catch (Exception)
        {
            return Problem();
        }
    }

    // ---------------------------------------------------------------------- //

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _taskService.Delete(id);

            return NoContent();
        }

        catch (Exception e)
        {
            if (e is NotFoundException) return NotFound(e.Message);

            return Problem();
        }
    }

    // ---------------------------------------------------------------------- //

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UpdateTaskDto dto)
    {
        try
        {
            var task = _taskService.Update(id, dto);

            return CreatedAtAction(nameof(FindById), new {id = task.Id }, task);
        }

        catch (Exception e)
        {
            if (e is NotFoundException) return NotFound(e.Message);

            return Problem();
        }
    }
}
