using Crud.Shared.Entities;
using Crud.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace IamKimBumJunCom.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController(IGameService gameService) : ControllerBase
{
    private readonly IGameService _gameService = gameService;

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGameById(int id)
    {
        var game = await _gameService.GetGameById(id);
        return Ok(game);
    }

    [HttpPost]
    public async Task<ActionResult<Game>> AddGameAsync([FromBody] Game game)
    {
        var newGame = await _gameService.AddGame(game);
        return Ok(newGame);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Game>> UpdateGameAsync(int id, [FromBody] Game game)
    {
        var updatedGame = await _gameService.UpdateGame(id, game);
        return Ok(updatedGame);
    }

    [HttpDelete("{id}")]
    public async Task<bool> DeleteGame(int id)
    {
        return await _gameService.DeleteGame(id);
    }
}
