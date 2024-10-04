using System;
using Microsoft.AspNetCore.SignalR;

namespace SignalRWebpack.Hubs;

public class ChatHub : Hub
{
    public const string HubUrl = "/hub/chat";
    public async Task NewMessage(long username, string message)
    {
        await Clients.All.SendAsync("messgeReceived", username, message);
    }

    public override async Task OnConnectedAsync()
    {
        await Clients.All.SendAsync("userConnected", Context.ConnectionId);
        _ = base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? e)
    {
        await Clients.All.SendAsync($"userDisconnected {e?.Message}", Context.ConnectionId);

        await base.OnDisconnectedAsync(e);
    }
}
