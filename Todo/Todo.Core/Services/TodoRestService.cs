using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    public class TodoRestService:ITodoService
    {
        private ITodoRestService restService = RestService.For<ITodoRestService>("https://msgbarometer.azurewebsites.net");
        
        public Task<List<TodoItem>> GetTodoItems()
        {
            return restService.GetTodos();
        }

        public Task<TodoItem> GetTodoItem(string id)
        {
            return restService.GetTodo(id);
        }

        public void AddOrUpdateTodoItem(TodoItem item)
        {
            if (string.IsNullOrEmpty(item.Id))
            {
                restService.CreateTodo(item);
            }
            else
            {
                restService.UpdateTodo(item);
            }
        }

        public void DeleteTodoItem(TodoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}