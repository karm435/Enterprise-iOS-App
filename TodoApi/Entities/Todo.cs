using System;
namespace TodoApi.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string? Title { get; set; } = default;
        public string? Description { get; set; } = default;
        public bool IsCompleted { get; set; }
    }
}

