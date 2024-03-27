using Crud.Shared.Data;
using Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Shared.Services;

public class GameService(DataContext db) : IGameService
{
    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1_000);
        var games = await db.Games.ToListAsync(); ;
        return games;
    }

    public async Task<Game> AddGame(Game game)
    {
        await db.Games.AddAsync(game);
        await db.SaveChangesAsync();

        return game;
    }
}
