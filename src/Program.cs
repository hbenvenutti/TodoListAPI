using Microsoft.EntityFrameworkCore;
using TodoList.Infra;
using TodoList.Infra.Repositories;
using TodoList.Infra.Repositories.Interfaces;
using TodoList.Providers.Mapper;
using TodoList.Services;
using TodoList.Services.Interfaces;

// * ---------------------------------------------------------------------- * //

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// *** --- database ---------------------------------------------------- *** //

services.AddDbContext<Context>(options =>
    options.UseInMemoryDatabase("TodoList"));

// *** --- mappers ----------------------------------------------------- *** //

services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

services.AddScoped<IMapperProvider, Mapper>();

// *** --- dependencies ------------------------------------------------- *** //

services.AddScoped<ITaskService, TaskService>();

services.AddScoped<ITaskRepository, TaskRepository>();

// * --- auto generated --------------------------------------------------- * //

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

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
