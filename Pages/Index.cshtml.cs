using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
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

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var task = await _context.Tasks.FindAsync(id);

        if (task == null)
        {
            return NotFound();
        }

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();

        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostFinishTask(int id)
    {
        var task = await _context.Tasks.FindAsync(id);

        if (task == null)
        {
            return NotFound();
        }

        if (task.Frequency == 0)
        {
            _context.Tasks.Remove(task);
        }
        else
        {
            task.LastCompleted = DateTime.Now;
            task.NextDue = task.NextDue.AddDays(task.Frequency);
            _context.Tasks.Update(task);
        }

        await _context.SaveChangesAsync();
        return RedirectToPage();
    }
}

