using Microsoft.EntityFrameworkCore;

namespace Buddham;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Game> Games { get; set; }
}
