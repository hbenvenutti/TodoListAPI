using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Infra;

public class Context : DbContext
{
    public DbSet<TaskModel> Tasks { get; set; }

    public Context(DbContextOptions<Context> options) : base(options) {}
}
