# Kim Bum Jun

```bash
npm install tailwindcss postcss autoprefixer postcss-cli
npm tailwindcss init

dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

# -m : 모델이름
# -dc : 네임스페이스를 포함하여 사용할 DbContext 클래스
# -udl : 기본 레이아웃
# -outDir : 뷰를 만들기 위한 상태 출력 폴더 경로
# --referenceScriptLibraries : Edit 및 Create 페이지에 _ValidtionScriptsPartial 을 추가함.
dotnet aspnet-codegenerator razorpage -m Movie -dc Iam.Data.IamContext -udl -outDir Components/Pages/Movie --databaseProvider sqlite
```

## **postcss.config.js**

```json
module.exports = {
  plugins: {
    tailwindcss: {},
    autoprefixer: {},
  },
}
```

```bash
npx tailwindcss -i ./Iam/wwwroot/css/styles.css -o ./Iam/wwwroot/css/styles.min.css --watch

history
npm install @tailwindcss/forms
npm install @tailwindcss/typography
npm install @tailwindcss/aspect-ratio
npm install @tailwindcss/line-clamp
```

## .razor

- @using
- @section
- @typeparam
- @attributes
- @bind
- @bind:culture
- @formname
- @on{EVENT}
- @on{EVENT}:stopPropagation
- @key
- @ref
