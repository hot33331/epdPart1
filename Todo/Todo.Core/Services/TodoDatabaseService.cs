using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    public class TodoDatabaseService:ITodoService
    {
        public Task<List<TodoItem>> GetTodoItems()
        {
            throw new System.NotImplementedException();
        }

        public Task<TodoItem> GetTodoItem(string id)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrUpdateTodoItem(TodoItem item)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTodoItem(TodoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}