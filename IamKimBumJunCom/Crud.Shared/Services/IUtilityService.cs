using Crud.Shared.Entities;

namespace Crud.Shared.Services;

public interface IUtilityService
{
    Task<List<Utility>> GetAllUtilities();
    Task<Utility> AddUtility(Utility utility);
    Task<Utility> UpdateUtility(Utility utility);
    Task<Utility> DeleteUtility(int id);
}
