using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskDbContext = TaskManager.Data.TaskDbContext;
using Task = TaskManager.Models.Task;

public class CreateModel : PageModel
{
    private readonly TaskDbContext _context;

    public CreateModel(TaskDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Task Task { get; set; }

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Tasks.Add(Task);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
