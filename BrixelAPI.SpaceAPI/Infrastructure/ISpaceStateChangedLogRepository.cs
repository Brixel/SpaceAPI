using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;

namespace BrixelAPI.SpaceState.Infrastructure
{
    interface ISpaceStateChangedLogRepository
    {
        Task AddAsync(SpaceStateChangedLog spaceStateChangedLog);

        Task<SpaceStateChangedLog> GetLastLogAsync();
    }
}