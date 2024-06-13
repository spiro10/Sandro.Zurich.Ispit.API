using Ispit.API.Models;

namespace Ispit.API.Services.Interfaces
{
    public interface ITodoListService
    {
        TodoList AddTodo(TodoListBinding model);
        TodoList DeleteTodo(int id);
        TodoList GetTodo(int id);
        List<TodoList> GetTodos();
        TodoList UpdateTodo(TodoList model);
    }
}