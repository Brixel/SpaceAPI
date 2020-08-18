using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    interface ISpaceStateChangedLogRepository
    {
        Task AddAsync(SpaceStateChangedLog spaceStateChangedLog);
    }
}