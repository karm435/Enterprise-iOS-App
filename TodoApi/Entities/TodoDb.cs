using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Entities
{
class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}

