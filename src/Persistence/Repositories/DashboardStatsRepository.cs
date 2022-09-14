using Application.Contracts.Persistence;
using Application.DTOs.Dashboard;
using Persistence.Constants;

namespace Persistence.Repositories;
internal class DashboardStatsRepository
{
    private readonly IDbHelpers _dbHelpers;

    public DashboardStatsRepository(IDbHelpers dbHelpers)
    {
        _dbHelpers = dbHelpers;
    }
    public async Task<StatsCounterDto> GetDashboardStatsAsync()
    {
        return await _dbHelpers.GetOneByStoreProcedureAsync<StatsCounterDto>(StoreProcedure.DashboardStats);
    }
}
