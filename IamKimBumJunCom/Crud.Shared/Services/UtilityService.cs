using Crud.Shared.Data;
using Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Shared.Services;

public class UtilityService(DataContext context) : IUtilityService
{
    public async Task<List<Utility>> GetAllUtilities()
    {
        await Task.Delay(1000);
        var utilities = await context.Utilities.ToListAsync();
        return utilities;
    }

    public async Task<Utility> AddUtility(Utility utility)
    {
        var data = await context.Utilities.AddAsync(utility);
        await context.SaveChangesAsync();
        return data.Entity;
    }

    public async Task<Utility> DeleteUtility(int id)
    {
        var utility = await context.Utilities.FindAsync(id) ?? throw new Exception("Not Found");
        context.Utilities.Remove(utility);
        await context.SaveChangesAsync();
        return utility;
    }

    public async Task<Utility> UpdateUtility(Utility utility)
    {
        var data = context.Utilities.Update(utility);
        await context.SaveChangesAsync();
        return data.Entity;
    }
}
