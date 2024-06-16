namespace BlazorTicTacToe.Shared;

public class GameRoom(string roomId, string roomName)
{
    public string RoomId { get; set; } = roomId;
    public string RoomName { get; set; } = roomName;
}
