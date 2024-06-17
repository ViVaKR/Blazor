# Blazor SignalR Chat

## NuGet Package

```bash

# nuget package (client)
dotnet add package Microsoft.AspNetCore.SignalR.Client

# [ tailwindcss ]
npm install tailwindcss
npm install -D tailwindcss
npx tailwindcss init

- mkdir ./Styles, ./wwwroot\css
npx tailwindcss -i Styles/app.css -o wwwroot/css/app.css --watch

module.exports = {
  content: ['./**/*.{razor,html}'],
  theme: {
    extend: {},
  },
  plugins: [],
};

# app.css
@tailwind base;
@tailwind components;
@tailwind utilities;

# 플렛폼 없이 약식
dotnet new blazor -n TailwindApp --empty -int None

# free tailwindcss site
https://flowbite.com/
https://www.mambaui.com/
https://www.hyperui.dev/

# [ Client ]
- Create 'Lobby' Component, Set @page "/"

# [ Server ]
- Remove 'Home, Weather, Count' Component, Modify MainLayout
```

## Ref. [Patric God](https://youtu.be/RsnndxBBFok?si=PeHHFLBt6J9AiLdy)
