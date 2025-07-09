using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure;

interface ISpaceStateRepository
{
    Task AddAsync(SpaceStateChangedLog spaceStateChangedLog);

    Task<SpaceStateChangedLog> GetLastLogAsync();
}