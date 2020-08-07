using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
{
    interface ISpaceStateRepository
    {
        Task AddAsync(Domain.SpaceStateAggregate.SpaceState spaceState);

        Task<Domain.SpaceStateAggregate.SpaceState> ReadAsync();
    }
}
