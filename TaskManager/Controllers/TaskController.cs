using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers;

public class TaskController : Controller
{
    public IActionResult Index()
    {
        List<TaskItem> tasks = new List<TaskItem>();

        TaskItem task1 = new TaskItem();
        task1.Id = 1;
        task1.Title = "Version 2.0 Update";
        task1.Description = "Get latest security updates by upgrading your version to 2.0";
        task1.Status = "Pending";

        TaskItem task2 = new TaskItem();
        task2.Id = 2;
        task2.Title = "Version 2.0 Bug Fixes";
        task2.Description = "Bugs were fixed reported by users.";
        task2.Status = "Pending";

        tasks.Add(task1);
        tasks.Add(task2);

        return View(tasks);
    }
}