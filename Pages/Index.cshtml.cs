using Microsoft.AspNetCore.Mvc.RazorPages;

using Models = TaskManager.Models;

public class IndexModel : PageModel
{
    public required List<Models.Task> Tasks { get; set; }

    public void OnGet()
    {
        // This is a mock list. Replace this with actual data fetching logic from a database or service.
        Tasks = new List<Models.Task>
        {
            new Models.Task
            {
                Id = 1,
                Name = "Task 1",
                DueDate = DateTime.Now.AddDays(1),
                Frequency = 10,
                EstimatedHours = 2,
                PreferredTime = new DateTime(1, 1, 1, 20, 0, 0), // 8:00 PM
                PreferredPlace = "Office"
            },
            new Models.Task
            {
                Id = 2,
                Name = "Task 2",
                DueDate = DateTime.Now.AddDays(2),
                Frequency = 5,
                EstimatedHours = 3,
                PreferredTime = new DateTime(1, 1, 1, 14, 0, 0), // 2:00 PM
                PreferredPlace = "Home"
            },
            // Add more tasks as needed
        };
    }
}
