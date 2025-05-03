namespace TicTacToe.Shared;

public class Player(string connectioiId, string name)
{
    public string ConnectionId { get; set; } = connectioiId;

    public string Name { get; set; } = name;
}