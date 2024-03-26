using IamKimBumJunCom.Data;
using IamKimBumJunCom.Entities;
using Microsoft.EntityFrameworkCore;

namespace IamKimBumJunCom.Services;

public class GameService(DataContext db) : IGameService
{
    public async Task<List<Game>> GetAllGames()
    {
        var games = await db.Games.ToListAsync(); ;
        return games;
    }
}
