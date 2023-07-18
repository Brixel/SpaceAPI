using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;

namespace BrixelAPI.SpaceState.Infrastructure;

interface ISpaceStateRepository
{
    Task AddAsync(SpaceStateChangedLog spaceStateChangedLog);

    Task<SpaceStateChangedLog> GetLastLogAsync();
}