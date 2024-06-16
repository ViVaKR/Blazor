using BlazorTicTacToe.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorTicTacToe.Hubs
{
    // GameHub class inherits from Hub class
    public class GameHub : Hub
    {
        private static readonly List<GameRoom> rooms = []; // List of GameRoom objects

        public override async Task OnConnectedAsync()
        {
            Console.WriteLine($"Player with Id '{Context.ConnectionId}' Connected.");
            await Clients.Caller.SendAsync("Rooms", rooms.OrderBy(r => r.RoomName));
        }

        public async Task<GameRoom> CreateRoom(string name, string playerName)
        {
            string roomId = Guid.NewGuid().ToString();
            GameRoom room = new(roomId, name);
            // room.Players.Add(new Player(Context.ConnectionId, playerName));
            rooms.Add(room);
            await Clients.All.SendAsync("Rooms", rooms.OrderBy(r => r.RoomName));
            return room;
        }
    }
}
