namespace TicTacToe.Shared;

public class TicTacToeGame
{
    public string? PlayerOId { get; set; } // Player O's ID

    public string? PlayerXId { get; set; } // Player X's ID

    public string? CurrentPlayerID { get; set; } // Current player's ID

    // 현재 플레이어의 심볼
    public string CurrentPlayerSymbol => CurrentPlayerID == PlayerXId ? "X" : "O";

    // 게임이 시작되었는지 여부
    public bool GameStarted { get; set; } = false;

    // 게임이 끝났는지 여부
    public bool GameOver { get; set; } = false;

    // 무승부 여부
    public bool IsDraw { get; set; } = false;

    // 승자
    public string Winner { get; set; } = string.Empty;

    // 게임 보드
    public List<List<string>> Board { get; set; } = new List<List<string>>(3);

    public TicTacToeGame()
    {
        InitializeBoard();
    }

    // 게임 보드 초기화
    public void InitializeBoard()
    {
        Board.Clear();
        Console.WriteLine("보드 초기화 시작");
        Board =
        [
            ["", "", ""],
            ["", "", ""],
            ["", "", ""]
        ]; // 보드 초기화
    }

    // 게임 시작
    public void StartGame()
    {
        CurrentPlayerID = PlayerXId;

        GameStarted = true;
        GameOver = false;
        Winner = string.Empty;
        IsDraw = false;

        InitializeBoard();
    }

    // 플레이어를 토글하는 메서드
    public void TogglePlayer()
    {
        CurrentPlayerID = CurrentPlayerID == PlayerXId ? PlayerOId : PlayerXId;
    }

    // 움직임을 만들어내는 메서드
    public bool MakeMove(int row, int col, string playerId)
    {
        if (playerId != CurrentPlayerID
        || row < 0 || row >= 3
        || col < 0 || col >= 3
        || Board[row][col] != string.Empty)
        {
            return false;
        }

        Board[row][col] = CurrentPlayerSymbol;
        TogglePlayer();
        return true;
    }

    /// <summary>
    /// Check if there is a winner or a draw
    /// </summary>
    /// <returns></returns>
    public string CheckWinner()
    {
        // Check rows
        // 가로로 체크
        for (int i = 0; i < 3; i++)
        {
            if (Board[i][0] == Board[i][1] && Board[i][1] == Board[i][2] && !string.IsNullOrEmpty(Board[i][0]))
            {
                GameOver = true;
                Winner = Board[i][0];
                return Winner;
            }
        }

        // 세로로 체크
        for (int i = 0; i < 3; i++)
        {
            if (Board[0][i] == Board[1][i] && Board[1][i] == Board[2][i] && !string.IsNullOrEmpty(Board[0][i]))
            {
                GameOver = true;
                Winner = Board[0][i];
                return Winner;
            }
        }

        // 좌상에서 우하로 대각선 체크
        if (Board[0][0] == Board[1][1] && Board[1][1] == Board[2][2] && !string.IsNullOrEmpty(Board[0][0]))
        {
            GameOver = true;
            Winner = Board[0][0];
            return Winner;
        }

        // 우상에서 좌상으로 대각선 체크
        if (Board[0][2] == Board[1][1] && Board[1][1] == Board[2][0] && Board[0][2] != string.Empty)
        {
            GameOver = true;
            Winner = Board[0][2];
            return Winner;
        }

        return Winner;
    }

    // 승자가 없고, 모든 칸이 채워져 있으면 무승승
    public bool CheckDraw()
    {
        return IsDraw = Board.All(row => row.All(cell => cell != string.Empty));
    }

}
