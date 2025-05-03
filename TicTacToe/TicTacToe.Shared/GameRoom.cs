namespace TicTacToe.Shared;

public class GameRoom(string roomId, string roomName)
{
    public string RoomId { get; set; } =  roomId;
    public string RoomName { get; set; } = roomName;
    public List<Player> Players { get; set; } = [];
    public TicTacToeGame Game { get; set; } = new();

    public bool TryAddPlayer(Player player)
    {
        if(Players.Count >= 2 || Players.Any(p=> p.ConnectionId == player.ConnectionId)) return false;
        
        Players.Add(player);

        switch (Players.Count)
        {
            case 1:
                
                break;
            case 2:
                break;
        }
        
        return true;
    }
}