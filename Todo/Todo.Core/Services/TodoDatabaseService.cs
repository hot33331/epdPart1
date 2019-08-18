using System.Collections.Generic;
using Todo.Core.Model;

namespace Todo.Core.Services
{
    public class TodoDatabaseService:ITodoService
    {
        public List<TodoItem> GetTodoItems()
        {
            throw new System.NotImplementedException();
        }

        public TodoItem GetTodoItem(string id)
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