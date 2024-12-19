using VivaKrWeb.Web.Components;
using VivaKrWeb.Shared.Services;
using VivaKrWeb.Web.Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("https://localhost:50005");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpClient();
// Add device-specific services used by the VivaKrWeb.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(VivaKrWeb.Shared._Imports).Assembly);

app.Run();
