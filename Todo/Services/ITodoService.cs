using Todo.Models;

namespace Todo.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetAll();
        void Add(TodoItem task);
        void ToggleComplete(int id);
        void Delete(int id);
    }
}
