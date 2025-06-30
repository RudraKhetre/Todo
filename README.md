# 📝 Task Manager (ASP.NET Core MVC)

A simple task manager web application built with **ASP.NET Core MVC**, demonstrating clean separation of concerns with an in-memory data store.

---

## 🚀 Features

- View a list of tasks
- Add a new task (with title, completion status)
- Toggle task completion (mark complete/incomplete)
- Delete a task
- Uses an in-memory list (no database)
- Clean separation of UI ➝ Controller ➝ Service ➝ Data
---


## 🗂️ Project Structure
```plaintext

/Controllers
    TaskController.cs
/Models
    TaskItem.cs
/Services
    ITaskService.cs
    TaskService.cs
/Views
    /Task
        Index.cshtml
        Create.cshtml

```
        
⚙️ Technology
ASP.NET Core MVC (minimal, clean implementation)
.NET 8
In-memory list for storing tasks
Bootstrap for simple styling


🏗️ Architecture
UI: Razor views for displaying and adding tasks
Controller: Handles user requests and routes
Service: TaskService with ITaskService interface, injected via dependency injection
Data: List of tasks in memory (no database)


🖥️ Screenshots
Task List	Add Task

![image](https://github.com/user-attachments/assets/75842e39-7cd4-4e31-96cf-34e731603e44)
![image](https://github.com/user-attachments/assets/7247eb21-a843-45bb-90d1-33ce6766c23d)



🏃‍♂️ How to Run
Clone the repository:
git clone https://github.com/RudraKhetre/Todo.git


Navigate into the project:
cd TaskManager

Restore dependencies:
dotnet restore

Run the application:
dotnet run

Open your browser at:

https://localhost:5001/Task

🔨 Usage

✅ Click Add Task to create a new task
✅ Toggle complete/incomplete from the list
✅ Delete tasks as needed
---

