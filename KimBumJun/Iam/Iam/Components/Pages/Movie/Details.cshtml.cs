using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Iam.Components.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly Iam.Data.IamContext _context;

        public DetailsModel(Iam.Data.IamContext context)
        {
            _context = context;
        }

        public Models.Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (movie is not null)
            {
                Movie = movie;

                return Page();
            }

            return NotFound();
        }
    }
}
