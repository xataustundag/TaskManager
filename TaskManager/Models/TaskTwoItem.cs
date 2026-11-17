namespace TaskManager.Models;

public class TaskTwoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Status { get; set; } = "Not Started";
    // If Status value == Completed than IsCompleted == true;
    public bool IsCompleted
    {
        get
        {
            return Status == "Completed";
        }
    }
}