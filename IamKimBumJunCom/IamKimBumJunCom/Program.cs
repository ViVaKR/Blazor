using IamKimBumJunCom.Components;
using Microsoft.EntityFrameworkCore;
using Crud.Shared.Data;
using Crud.Shared.Services;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// 배포시 제거 항목
var conStrBuilder = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("DefaultConnection"))
{
    Password = builder.Configuration["IamKimBumJunCom:DbPassword"]
};
var connection = conStrBuilder.ConnectionString;

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents().AddInteractiveWebAssemblyComponents();

//--> DI (종속성 주입 파트)
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(connection));

builder.Services.AddScoped<IGameService, GameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(IamKimBumJunCom.Client._Imports).Assembly);

app.Run();


/*
--> 비밀 관리자 도구
# 파일 시스템 경로
Linux / macOS : ~/.microsoft/usersecrets/{userSecretsId}/secrets.json
Windows : %APPDATA%\Microsoft\UserSecrets\{userSecretsId}\secrets.json

(1) CLI
# 프로젝트 폴더로 이동
$ dotnet user-secrets init
# 위 명령은 PropertyGroup에 UserSecretsId 추가됨 (csproj 파일)

# 비밀 관리자 도구로 비밀 추가 (키:값) 형태로 저장, 중복되면 덮어씀, 띄어쓰기 포함 불가, 대소문자 구분, 특수문자 사용 가능, 값은 문자열만 가능
# 위 명령은 secrets.json 파일에 추가, 생성됨
$ dotnet user-secrets set "IamKimBumJunCom:ConnectionString" "Server=localhost;Database=IamKimBumJunCom;User Id=IamKimBumJunCom;Password=1234;"
$ dotnet user-secrets set "Movies:ServiceApiKey" "12345" --project "C:\apps\WebApp1\src\WebApp1"

# e.g., secrets.json
{
  "Movies": {
    "ConnectionString": "Server=(localdb)\\mssqllocaldb;Database=Movie-1;Trusted_Connection=True;MultipleActiveResultSets=true",
    "ServiceApiKey": "12345"
  }
}

# e.g., appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Movie-1;Trusted_Connection=True;MultipleActiveResultSets=true"
}

# e.g., 일괄 처리
$ cat ./input.json | dotnet user-secrets set


# 비밀 관리자 도구로 비밀 목록 확인
$ dotnet user-secrets list

# 단일 비밀 제거
$ dotnet user-secrets remove "Movies:ConnectionString"

# 모든 비밀 제거
$ dotnet user-secrets clear

(

# [ ASP.NET Core 프로젝트에서 비밀 사용 ]
# 패키지 설치 (.NET CLI)
$ dotnet add package Microsoft.Extensions.Configuration
$ dotnet add package Microsoft.Extensions.Configuration.UserSecrets
# 패키지 설치 (NuGet 패키지 관리자)
$ Install-Package Microsoft.Extensions.Configuration
$ Install-Package Microsoft.Extensions.Configuration.UserSecrets

# [ API 를 통해 비밀 읽기 ]
var builder = WebApplication.CreateBuilder(args);
var apiKey = builder.Configuration["IamKimBumJunCom:ServiceApiKey"];
var app = builder.Build();
app.MapGet("/apikey", () => apiKey);

IConfigurationRoot config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string? sec = config["IamKimBumJunCom:ConnectionString"] ?? connection;
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var apiKey = builder.Configuration["IamKimBumJunCom:ServiceApiKey"];
app.MapGet("/apikey", () => connection);
 */
