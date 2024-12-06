using Iam.Components;
using Microsoft.EntityFrameworkCore;
using Iam.Data;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<IamContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("IamContext")));
}
else
{
    builder.Services.AddDbContext<IamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IamContext")));
}

builder.WebHost.UseUrls("https://localhost:52225");

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();


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

// hello

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Iam.Client._Imports).Assembly);

app.Run();
