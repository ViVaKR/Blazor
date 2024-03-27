using Crud.Shared.Entities;

namespace Crud.Shared.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
    Task<Game> AddGame(Game game);
}
