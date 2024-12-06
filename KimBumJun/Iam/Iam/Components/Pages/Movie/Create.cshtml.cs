using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iam.Components.Pages.Movie;

public class CreateModel(Iam.Data.IamContext context) : PageModel
{
    private readonly Iam.Data.IamContext _context = context;

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    // public Movie Movie { get; set; } = default!;
    public required Models.Movie Movie { get; set; }

    // For more information, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Movie.Add(Movie);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
