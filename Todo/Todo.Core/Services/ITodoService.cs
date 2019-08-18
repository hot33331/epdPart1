using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetTodoItems();
        Task<TodoItem> GetTodoItem(string id);
        void AddOrUpdateTodoItem(TodoItem item);
        void DeleteTodoItem(TodoItem item);
    }
}