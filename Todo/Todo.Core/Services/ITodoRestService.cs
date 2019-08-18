using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    [Headers("zumo-api-version: 2.0.0")]
    public interface ITodoRestService
    {
            
            [Get("/tables/Todo")]
            Task<List<TodoItem>> GetTodos();
            [Post("/tables/Todo")]
            Task CreateTodo([Body] TodoItem item);
            
            [Get("/tables/Todo/{id}")]
            Task<TodoItem> GetTodo(string id);
            
            [Delete("/tables/Todo/{id}")]
            Task<TodoItem> DeleteTodo(string id);
        
            [Patch("/tables/Todo/{id}")]
            Task<TodoItem> UpdateTodo(string id);
    }
}