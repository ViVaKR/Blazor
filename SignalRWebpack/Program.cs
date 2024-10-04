using SignalRWebpack.Hubs;

var builder = WebApplication.CreateBuilder(args);
var corsapp = "allowAll";

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsapp, builder =>
    {
        builder.WithOrigins("http://localhost:4456, http://localhost:4200", "http://localhost:5083") // Angular 앱의 URL
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials();
    });
});

builder.Services.AddSignalR();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
var app = builder.Build();

app.MapHub<ChatHub>("/hub");
app.MapGet("/", () =>
{
    return Results.Content("<h1>ViVaKR</h1>", "text/html");
});
app.UseCors(corsapp);
app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();
