using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Iam.Components.Pages.Movie;

public class IndexModel(Iam.Data.IamContext context) : PageModel
{
    private readonly Iam.Data.IamContext _context = context;

    public IList<Models.Movie> Movie { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Movie = await _context.Movie.ToListAsync();
    }
}
