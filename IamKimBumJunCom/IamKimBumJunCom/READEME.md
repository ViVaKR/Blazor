# iam.kimbumjun.com

## Code First EntityFramework Settings

1. Create Entity -> Create Folder `Entities` -> Model class `Game`
2. Create DataContext -> Create folder `Data` -> Context class `DataContext`
3. Connection config `appsettings.json` -> ref. (1)
4. Dependency Injection `program.cs` -> ref. (2)
5. Migration -> ref. (3)
6. Create Service folder `Services`
7. Create interface `IGame.cs`
8.

-- ref. (1)

```json
    // Connection String Setting Example (appsettings.json)
    "ConnectionStrings": {
        "DefaultConnection": "Server=192.168.0.8,59273;Database=IamKimBumJunCom;User ID=IamKimBumJunCom;Password=<비밀#번호>;TrustServerCertificate=True"
    }

```

-- ref. (2)

```cs
    // DI Example (program.cs)
    builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

```

-- ref. (3)

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
