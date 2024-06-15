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

    public async Task<Game> UpdateGame(int id, Game game)
    {
        var data = db.Games.Update(game);
        await db.SaveChangesAsync();
        return data.Entity;
    }

    public async Task<Game> GetGameById(int id)
    {
        var data = await db.Games.FindAsync(id) ?? throw new Exception("Not Found");
        await db.SaveChangesAsync();
        return data;
    }

    public async Task<bool> DeleteGame(int id)
    {
        var data = await db.Games.FindAsync(id);
        if (data is not null)
        {
            db.Remove(data);
            await db.SaveChangesAsync();
            return true;
        }
        return false;
    }

}
