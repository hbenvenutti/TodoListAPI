using TodoList.Infra.Repositories.Interfaces;
using TodoList.Models;

namespace TodoList.Infra.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly Context _context;

    // *** --- constructors --------------------------------------------- *** //

    public TaskRepository(Context context)
    {
        _context = context;

        return;
    }

    // *** --- public methods ------------------------------------------- *** //

    public TaskModel Create(TaskModel task)
    {
        _context.Tasks.Add(task);

        _context.SaveChanges();

        return task;
    }

    // ---------------------------------------------------------------------- //

    public void Delete(TaskModel task)
    {
        _context.Tasks.Remove(task);

        _context.SaveChanges();

        return;
    }

    // ---------------------------------------------------------------------- //

    public TaskModel? FindById(int id)
    {
        var task = _context.Tasks.Find(id);

        return task;
    }

    // ---------------------------------------------------------------------- //

    public IEnumerable<TaskModel> List()
    {
        return _context.Tasks.ToList();
    }

    // ---------------------------------------------------------------------- //

    public TaskModel Update(TaskModel task)
    {
       _context.Tasks.Update(task);

       _context.SaveChanges();

       return task;
    }
}
