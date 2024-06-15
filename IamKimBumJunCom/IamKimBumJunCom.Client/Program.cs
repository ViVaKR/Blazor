using Crud.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGameService, ClientGameService>();

builder.Services.AddScoped<IUtilityService, UtilityService>();

await builder.Build().RunAsync();
