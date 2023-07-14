using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
{
    interface ISpaceStateRepository
    {
        Task AddAsync(Domain.SpaceStateAggregate.SpaceApi spaceState);

        Task<Domain.SpaceStateAggregate.SpaceApi> ReadAsync();
    }
}
