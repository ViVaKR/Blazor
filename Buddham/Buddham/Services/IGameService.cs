namespace Buddham;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
}
