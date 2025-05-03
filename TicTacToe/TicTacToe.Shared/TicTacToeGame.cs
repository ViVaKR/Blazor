namespace TicTacToe.Shared;

public class TicTacToeGame
{
    public string? PlayerOId { get; set; } // O
    public string? PlayerXId { get; set; } // X

    public string? CurrentPlayerID { get; private set; }
    public string CurrentPlayerSymbol 
        => CurrentPlayerID == PlayerXId ? "X" : "O";

    public bool GameStarted { get; private set; }
    public bool GameOver { get; private set; }
    public bool IsDraw { get; private set; }
    public string Winner { get; private set; } = string.Empty;
    public List<List<string>> Board { get; private set; } = new(3);

    public TicTacToeGame()
    {
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        Board =
        [
            new List<string> { "", "", "" },
            new List<string> { "", "", "" },
            new List<string> { "", "", "" }
        ];
    }

    public void StartGame()
    {
        CurrentPlayerID = PlayerXId;
        GameStarted = true;
        GameOver = false;
        IsDraw = false;
        Winner = string.Empty;
        InitializeBoard();
    }

    private void TogglePlayer()
    {
        CurrentPlayerID = CurrentPlayerID == PlayerXId ? PlayerOId : PlayerXId;
    }

    public bool MakeMove(int row, int col, string playerId)
    {
        if (!GameStarted || GameOver || playerId != CurrentPlayerID ||
            row < 0 || row >= 3 || col < 0 || col >= 3 || Board[row][col] != "")
        {
            return false;
        }

        Board[row][col] = CurrentPlayerSymbol;

        if (CheckWinner()) return true;
        if (CheckDraw()) return true;

        TogglePlayer();
        return true;
    }

    private static bool IsLine(string a, string b, string c)
        => !string.IsNullOrEmpty(a) && a == b && b == c;

    private bool CheckWinner()
    {
        // 가로 및 세로 체크
        for (var i = 0; i < 3; i++)
        {
            if (!IsLine(Board[i][0], Board[i][1], Board[i][2]) &&
                !IsLine(Board[0][i], Board[1][i], Board[2][i])) continue;
            DeclareWinner(Board[i][0]);
            return true;
        }

        // 대각선 체크
        if (!IsLine(Board[0][0], Board[1][1], Board[2][2]) &&
            !IsLine(Board[0][2], Board[1][1], Board[2][0])) return false;
        DeclareWinner(Board[1][1]);
        return true;

    }

    private void DeclareWinner(string winnerSymbol)
    {
        GameOver = true;
        Winner = winnerSymbol;
    }

    private bool CheckDraw()
    {
        if (!Board.All(row => row.All(cell => cell != ""))) return false;
        GameOver = true;
        IsDraw = true;
        return true;

    }
}
