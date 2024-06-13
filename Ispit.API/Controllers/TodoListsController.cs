using Ispit.API.Models;
using Ispit.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ispit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListsController : ControllerBase
    {
        private readonly ITodoListService _todoListService;

        public TodoListsController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<TodoList>),200)]
        public ActionResult<List<TodoList>> GetTodos()
        {
            var items = _todoListService.GetTodos();
            return Ok(items);
        }

        [HttpPost]
        [ProducesResponseType(typeof(TodoList), 200)]
        public ActionResult<TodoList> AddTodo(TodoListBinding model)
        {
            var item = _todoListService.AddTodo(model);
            return Ok(item);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TodoList), 200)]
        public ActionResult<TodoList> GetTodo(int id)
        {
            var item = _todoListService.GetTodo(id);
            return Ok(item);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TodoList), 200)]
        public ActionResult<TodoList> UpdateTodo(TodoList model)
        {
            var item = _todoListService.UpdateTodo(model);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(TodoList), 200)]
        public ActionResult<TodoList> DeleteTodo(int id)
        {
            var item = _todoListService.DeleteTodo(id);
            return Ok(item);
        }


    }
}
