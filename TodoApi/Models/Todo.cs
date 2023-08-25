using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Todo
    {
        public Guid id { get; set; }
        [Required]
        public string? title { get; set; } = default;
        [Required]
        public bool isCompleted { get; set; }
    }
}

