namespace BlazorTicTacToe.Shared;

public class GameRoom(string roomId, string roomName)
{
    public string RoomId { get; set; } = roomId;

    public string RoomName { get; set; } = roomName;

    public List<Player> Players { get; set; } = [];

    public TicTacToeGame Game { get; set; } = new TicTacToeGame();

    public bool TryAddPlayer(Player player)
    {
        if (Players.Count < 2 && !Players.Any(p => p.ConnectionId == player.ConnectionId))
        {
            Players.Add(player);
            if (Players.Count == 1)
            {
                Game.PlayerXId = player.ConnectionId;
            }
            else if (Players.Count == 2)
            {
                Game.PlayerOId = player.ConnectionId;
            }
            return true;
        }
        return false;
    }
}
