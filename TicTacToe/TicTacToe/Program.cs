using Microsoft.AspNetCore.ResponseCompression;
using TicTacToe.Components;
using TicTacToe.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR(); // <--- 이 줄을 추가하세요!

// builder.WebHost.UseUrls("https://localhost:59374");
builder.WebHost.UseUrls("https://localhost:59481");

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(["application/octet-stream"]);
});

builder.Services.AddRazorComponents().AddInteractiveWebAssemblyComponents();

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
app.UseResponseCompression();
app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(TicTacToe.Client._Imports).Assembly);

app.MapHub<ChatHub>("/chathub");
app.MapHub<GameHub>("/gamehub");
app.Run();
