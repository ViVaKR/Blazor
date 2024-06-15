#! /usr/bin/env zsh

dotnet build && dotnet ef migrations add $1 -c DataContext -o Data/Migrations

# dotnet ef database update -c DataContext
