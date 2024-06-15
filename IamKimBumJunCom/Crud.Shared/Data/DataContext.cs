using Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Shared.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Utility> Utilities => Set<Utility>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

/*
    $ dotnet tool install --global dotnet-ef
    $ dotnet tool update --global dotnet-ef

    $ (optional) dotnet tool install --global dotnet-aspnet-codegenerator

    $ (optioonal) dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    $ dotnet add package Microsoft.EntityFrameworkCore.Design
    $ dotnet add package Microsoft.EntityFrameworkCore.Tools

    $ dotnet ef migrations add InitialCreate --output-dir Data/Migrations
    $ dotnet ef database update
 */
