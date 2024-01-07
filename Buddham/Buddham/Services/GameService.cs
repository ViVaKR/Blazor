
using Microsoft.EntityFrameworkCore;

namespace Buddham;

public class GameService(DataContext context) : IGameService
{
    private readonly DataContext _context = context;

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1_000);
        var games = await _context.Games.ToListAsync();
        return games;
    }
}
