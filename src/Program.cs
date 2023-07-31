using Microsoft.EntityFrameworkCore;
using TodoList.Infra;
using TodoList.Infra.Repositories;
using TodoList.Infra.Repositories.Interfaces;
using TodoList.Services;
using TodoList.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>(options =>
    options.UseInMemoryDatabase("TodoList"));

// *** --- dependencies ------------------------------------------------- *** //

builder.Services.AddScoped<ITaskService, TaskService>();

builder.Services.AddScoped<ITaskRepository, TaskRepository>();

// * --- auto generated --------------------------------------------------- * //

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
