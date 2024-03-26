using IamKimBumJunCom.Entities;
using Microsoft.EntityFrameworkCore;

namespace IamKimBumJunCom.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

/*
    $ dotnet tool install --global dotnet-ef
    $ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    $ dotnet add package Microsoft.EntityFrameworkCore.Design
    $ dotnet add package Microsoft.EntityFrameworkCore.Tools
    $ dotnet ef migrations add InitialCreate --output-dir Data/Migrations
    $ dotnet ef database update
 */
