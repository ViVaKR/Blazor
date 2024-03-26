# Blazor WebApp


## Start CLI

```bash

    # Help
    $ dotnet new blazor -h

    # Create New
    $ dotnet new blazor -o Buddham -int Auto --no-https false --empty false
    $ dotnet new blazor -o Kr.Or.Writer.WebApp -n WriterWebApp -f net8.0 -au Individual -int Auto --no-https false -uld true

    # dotnet ef
    $ dotnet tool install --global dotnet-ef
    $ dotnet tool update --global dotnet-ef

    $ dotnet add package Microsoft.EntityFrameworkCore.Design
    $ dotnet ef
    $ dotnet ef dbcontext info
    $ dotnet ef dbcontext list

    # Inital Migration
    $ dotnet ef migrations add Inital
    $ dotnet ef database update

    # Add Component
    $ dotnet new razorcomponent -o Components/Pages -n GameList

    # watch
    $ dotnet watch --launch-profile https
```

## rendermode

* @rendermode InteractiveServer
* @rendermode InteractiveWebAssembly
* @rendermode InteractiveAuto


```json
// exmaple 1
"DefaultConnection":"Servre=.\\SQLEXPRESS;Database=DbName;Trusted_connection=True;TrustServerCertificate=True;"
// example 2
"DefaultConnection": "server=locahost,1234;database=DbName;user id=UserName; password=비밀번호;TrustServerCertificate=True;"
```
