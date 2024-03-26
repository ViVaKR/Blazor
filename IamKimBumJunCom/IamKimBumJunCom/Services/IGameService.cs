using IamKimBumJunCom.Entities;

namespace IamKimBumJunCom.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
}
