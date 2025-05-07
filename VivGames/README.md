# Blazor

## Create

```bash
dotnet new blazor -o VivGame -int WebAssembly -ai true --auth Individual

dotnet new razorclasslib -o VivGames.Shared.Components
dotnet sln add VivGames.Shared.Components

cd VivGames
dotnet add reference ../VivGames.Shared.Components
cd ..
cd VivGames.Client
 dotnet add reference ../VivGames.Shared.Components

# cd solution root
cd VivGame
npm install tailwindcss @tailwindcss/postcss postcss @tailwindcss/cli

```
