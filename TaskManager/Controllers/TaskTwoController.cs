using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers;

public class TaskTwoController : Controller
{
    public static List<TaskTwoItem> tasks = new List<TaskTwoItem>();

    public IActionResult Index()
    {
        return View(tasks);
        //return Content("Task successfully added!");
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(string title, string description, string status)
    {
        // Check if Title Input Field is Empty or Not.
        if (string.IsNullOrWhiteSpace(title))
        {
            return BadRequest("Title for the field is required.");
        }

        // Values that are Allowed for Status section.
        string[] AllowedStatusValues =
        {
            "Not Started",
            "Pending",
            "Completed"
        };
        
        // If value given to status is not contained in AllowedStatusvalues then return BadRequest!
        if (!AllowedStatusValues.Contains(status))
        {
            return BadRequest($"Invalid status received: '{status}'");
        }

        TaskTwoItem newTask = new TaskTwoItem();
         // If tasks list is empty than instead of starting from newTask.Id = 0 we set it to newTask.Id = 0+1
         // If tasks list is not empty than we get the max t.Id value and add 1 to it. So Id numbers don't always start from beginning
        newTask.Id = tasks.Count == 0 ? 1 : tasks.Max(t => t.Id) + 1;

        newTask.Title = title;
        newTask.Description = description;
        newTask.Status = status;

        tasks.Add(newTask);
        
        return RedirectToAction("Index");
    }
}