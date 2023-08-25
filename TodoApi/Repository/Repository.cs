using System;
using TodoApi.Models;

namespace TodoApi.Repository
{
    public class TodoDb
    {
        private static List<Todo> _todos = new List<Todo>() {
        new Todo { id = Guid.NewGuid(), title = "Add api project", isCompleted = false },
        new Todo { id = Guid.NewGuid(), title = "Start Xcode project", isCompleted = false },
        new Todo { id = Guid.NewGuid(), title = "Get the todos" , isCompleted = true },
        new Todo { id = Guid.NewGuid(), title = "Fefactor the code", isCompleted = false },
        new Todo { id = Guid.NewGuid(), title = "Modularise the code", isCompleted = true }
    };

        public static IEnumerable<Todo> Get() => TodoDb._todos.ToArray();

        public static void Create(Todo todo)
        {
            todo.id = Guid.NewGuid();
            _todos.Add(todo);
        }

        public static Todo Update(Todo update)
        {
            _todos = _todos.Select(todo => {
                if (Guid.Equals(todo.id, update.id))
                {
                    todo.title = update.title;
                    todo.isCompleted = update.isCompleted;
                }
                return todo;
            }).ToList();
            return update;
        }

        public static void Delete(Guid id)
        {
            _todos = _todos.FindAll(t => t.id != id).ToList();
        }
    }
}

