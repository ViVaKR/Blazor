# Blazor Authentication & Authorization with Identity

## Change sqlite to SqlServer

1. Remove Migration Folder
2. Change "UseSqlite" to "UseSqlServer"

>- `builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));` To
>- `builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));`

```bash
dotnet ef migrations add "CreateIndentitySchema"
dotnet ef database update
```

## Pre Settings

```bash

    # install dotnet-ef tool
    dotnet tool install --global dotnet-ef
    dotnet tool update --global dotnet-ef

    # install packages
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools



    # migration
    dotnet ef migrations add InitialCreate --output-dir Data/Migrations
    dotnet ef database update --context DataContext


    # create new component
    dotnet new razorcomponent --output Components/Pages/Info

```
