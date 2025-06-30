using Todo.Models;

namespace Todo.Services
{
    public class TodoService :ITodoService
    {
        private readonly List<TodoItem> _tasks = new();
        private int _nextId = 1;

        public List<TodoItem> GetAll()
        {
            return _tasks;
        }

        public void Add(TodoItem task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
        }

        public void ToggleComplete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                task.IsCompleted = !task.IsCompleted;
        }

        public void Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                _tasks.Remove(task);
        }
    }
}
