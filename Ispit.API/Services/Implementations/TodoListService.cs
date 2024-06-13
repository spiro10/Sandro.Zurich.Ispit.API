using AutoMapper;
using Ispit.API.Data;
using Ispit.API.Models;
using Ispit.API.Services.Interfaces;

namespace Ispit.API.Services.Implementations
{
    public class TodoListService : ITodoListService
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext db;

        public TodoListService(IMapper mapper, ApplicationDbContext db)
        {
            this.mapper = mapper;
            this.db = db;
        }


        public List<TodoList> GetTodos()
        {
            var dbos = db.TodoLists.ToList();
            return dbos;
        }

        public TodoList GetTodo(int id)
        {
            var dbo = db.TodoLists.FirstOrDefault(x => x.Id == id);
            return dbo;
        }

        public TodoList AddTodo(TodoListBinding model)
        {
            var dbo = mapper.Map<TodoList>(model);
            db.TodoLists.Add(dbo);
            db.SaveChanges();
            return dbo;
        }

        public TodoList DeleteTodo(int id)
        {
            var dbo = GetTodo(id);
            db.TodoLists.Remove(dbo);
            db.SaveChanges();
            return dbo;
        }

        public TodoList UpdateTodo(TodoList model)
        {
            var dbo = GetTodo(model.Id);
            mapper.Map(model, dbo);
            db.SaveChanges();
            return dbo;
        }

    }
}
