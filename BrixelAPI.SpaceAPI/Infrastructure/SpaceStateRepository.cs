using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
{
    class SpaceStateRepository : ISpaceStateRepository
    {
        private readonly IFileSystem _fileSystem;

        public SpaceStateRepository(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }


        public async Task AddAsync(Domain.SpaceStateAggregate.SpaceState spaceState)
        {
            await _fileSystem.SaveAsync("spacestate.json", spaceState);
        }

        public async Task<Domain.SpaceStateAggregate.SpaceState> ReadAsync()
        {
            return await _fileSystem.ReadAsync<Domain.SpaceStateAggregate.SpaceState>("spacestate.json");
        }
    }
}