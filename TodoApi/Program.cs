using Microsoft.OpenApi.Models;
using TodoApi.Models;
using TodoApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todos api", Description = "Todos api for iOS app." });
});
builder.Services.AddCors(options => {});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo Api V1");
    });
}

app.MapGet("api/todos", () => TodoDb.Get());
app.MapGet("api/todos/{id}", (Guid id) => TodoDb.Get().SingleOrDefault(t => t.id == id));
app.MapPost("api/todos", (Todo todo) => TodoDb.Create(todo));
app.MapPut("api/todos", (Todo todo) => TodoDb.Update(todo));
app.MapDelete("api/todos/{id}", (Guid id) => TodoDb.Delete(id));

app.UseRouting();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
