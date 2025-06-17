# Blazor

## Create

```bash
dotnet new blazor -o VivGame -int WebAssembly -ai true --auth Individual
dotnet new razorclasslib -o VivGames.Shared.Components
dotnet sln add VivGames.Shared.Components

# VivGames
dotnet add reference ../VivGames.Shared.Components

# VivGames.Clinet
dotnet add reference ../VivGames.Shared.Components

# cd solution root

npm init -y
npm install tailwindcss @tailwindcss/postcss postcss @tailwindcss/cli

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.IdentityModel.Tokens
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Scalar.AspNetCore
dotnet add package System.IdentityModel.Tokens.Jwt

# Client Side
dotnet add package Microsoft.AspNetCore.SignalR.Client
```

## Create new Razor Page

- Run : `./make-razor-page.sh Demo`

```bash
#!/bin/bash
name=$1
folder=${2:-"Pages"}

mkdir -p $folder
cat <<EOF > $folder/$name.razor
@page "/${name,,}"

<h3>${name}</h3>

<p>This is the ${name} page.</p>
EOF
```
