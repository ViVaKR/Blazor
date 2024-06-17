using BlazorTicTacToe.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorTicTacToe.Hubs
{
    // GameHub class inherits from Hub class
    public class GameHub : Hub
    {
        // List of GameRoom objects
        private static readonly List<GameRoom> rooms = []; // List of GameRoom objects

        // Override the OnConnectedAsync method
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine($"Player with Id '{Context.ConnectionId}' Connected.");
            await Clients.Caller.SendAsync("Rooms", rooms.OrderBy(r => r.RoomName));
        }

        /// <summary>
        /// Create a new GameRoom object and add it to the rooms list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public async Task<GameRoom> CreateRoom(string name, string playerName)
        {
            // Create a new GameRoom object
            string roomId = Guid.NewGuid().ToString();

            // Add the new GameRoom object to the rooms list
            GameRoom room = new(roomId, name);
            rooms.Add(room);

            // Create a new Player object
            var newPlayer = new Player(Context.ConnectionId, playerName);

            // Add the new Player object to the GameRoom object
            room.TryAddPlayer(newPlayer);

            // Add the player to the SignalR group with the roomId
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            // Send the updated list of rooms to all clients
            await Clients.All.SendAsync("Rooms", rooms.OrderBy(r => r.RoomName));

            return room; // Return the new GameRoom object
        }

        public async Task<GameRoom?> JoinRoom(string roomId, string playerName)
        {
            // Find the GameRoom object with the specified roomId
            GameRoom? room = rooms.FirstOrDefault(r => r.RoomId == roomId);

            // If the GameRoom object is found
            if (room is not null)
            {
                // Create a new Player object
                var newPlayer = new Player(Context.ConnectionId, playerName);

                // Add the new Player object to the GameRoom object
                if (room.TryAddPlayer(newPlayer))
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, roomId); // Add the player to the SignalR group with the roomId
                    await Clients.All.SendAsync("PlayerJoined", newPlayer); // Send the updated list of rooms to all clients
                    return room; // Return the GameRoom object
                }
            }
            return null; // Return null if the GameRoom object is not found
        }

        public async Task StartGame(string roomId)
        {
            // Find the GameRoom object with the specified roomId
            GameRoom? room = rooms.FirstOrDefault(r => r.RoomId == roomId);

            // If the GameRoom object is found
            if (room is not null)
            {
                // Start the game
                room.Game.StartGame();

                // Send the updated list of rooms to all clients
                await Clients.All.SendAsync("UpdateGame", room);
            }
        }

        /// <summary>
        ///  Make a move in the game
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public async Task MakeMove(string roomId, int row, int col, string playerId)
        {
            // Find the GameRoom object with the specified roomId
            GameRoom? room = rooms.FirstOrDefault(r => r.RoomId == roomId);

            // If the GameRoom object is found and the move is valid
            // Make the move and check for a winner or draw
            // Send the updated list of rooms to all clients
            if (room is not null && room.Game.MakeMove(row, col, playerId))
            {
                room.Game.Winner = room.Game.CheckWinner();
                room.Game.IsDraw = room.Game.CheckDraw() && string.IsNullOrEmpty(room.Game.Winner);

                if (!string.IsNullOrEmpty(room.Game.Winner) || room.Game.IsDraw)
                {
                    room.Game.GameOver = true;
                }
                // Send the updated list of rooms to all clients
                await Clients.Group(roomId).SendAsync("UpdateGame", room);
            }
        }
    }
}
