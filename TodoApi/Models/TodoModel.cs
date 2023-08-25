using TodoApi.Entities;

namespace TodoApi.Models
{
    public class TodoModel    {
        public TodoModel() {  }
        public TodoModel(Todo todo)
        {
            Id = todo.Id;
            Title = todo.Title;
            Description = todo.Description;
            IsCompleted = todo.IsCompleted;
        }

        public Guid Id { get; set; }
        public string? Title { get; set; } = default;
        public string? Description { get; set; } = default;
        public bool IsCompleted { get; set; }
    }
}