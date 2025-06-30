using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _taskService;

        public TodoController(ITodoService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            var tasks = _taskService.GetAll();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoItem task)
        {
            if (ModelState.IsValid)
            {
                _taskService.Add(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }

        public IActionResult ToggleComplete(int id)
        {
            _taskService.ToggleComplete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _taskService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
