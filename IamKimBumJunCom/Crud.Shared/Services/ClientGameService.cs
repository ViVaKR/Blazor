using System.Net.Http.Json;
using Crud.Shared.Entities;

namespace Crud.Shared.Services;

public class ClientGameService(HttpClient http) : IGameService
{
    private readonly HttpClient _http = http;

    public async Task<Game> AddGame(Game game)
    {
        var result = await _http.PostAsJsonAsync<Game>("api/game", game);
        return await result.Content.ReadFromJsonAsync<Game>() ?? throw new Exception("Failed to add game");
    }

    public async Task<List<Game>> GetAllGames()
    {
        var data = await _http.GetFromJsonAsync<List<Game>>("api/game");
        return data ?? throw new Exception("Failed to get games");
    }

    public async Task<Game> GetGameById(int id)
    {
        var data = await _http.GetFromJsonAsync<Game>($"api/game/{id}");
        return data ?? throw new Exception("Not Found");
    }

    public async Task<Game> UpdateGame(int id, Game game)
    {
        var result = await _http.PutAsJsonAsync<Game>("api/game", game);
        return await result.Content.ReadFromJsonAsync<Game>() ?? throw new Exception("Failed to update game");
    }

    public async Task<bool> DeleteGame(int id)
    {
        var result = await _http.DeleteAsync($"api/game/{id}");
        return result.IsSuccessStatusCode;
    }
}
