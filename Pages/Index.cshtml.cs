using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Models = TaskManager.Models;

public class IndexModel : PageModel
{
    private readonly TaskManager.Data.TaskDbContext _context;

    public IndexModel(TaskManager.Data.TaskDbContext context)
    {
        _context = context;
    }

    public IList<Models.Task> Tasks { get; private set; }

    public async Task OnGetAsync()
    {
        Tasks = await _context.Tasks.ToListAsync();
    }
}
