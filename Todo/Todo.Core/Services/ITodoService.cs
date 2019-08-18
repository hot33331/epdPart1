using System.Collections.Generic;
using Todo.Core.Model;

namespace Todo.Core.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetTodoItems();
        TodoItem GetTodoItem(string id);
        void AddOrUpdateTodoItem(TodoItem item);
        void DeleteTodoItem(TodoItem item);
    }
}