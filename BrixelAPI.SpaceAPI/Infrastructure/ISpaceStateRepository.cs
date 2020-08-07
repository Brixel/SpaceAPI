using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BrixelAPI.SpaceState.Infrastructure
{
    interface IFileSystem
    {
        Task<T> ReadAsync<T>(string fileName);

        Task SaveAsync<T>(string fileName, T content);
    }

    class FileSystem : IFileSystem
    {
        public async Task<T> ReadAsync<T>(string fileName)
        {
            var bytes = await File.ReadAllBytesAsync(fileName);
            var memoryStream = new MemoryStream(bytes);
            var streamReader = new StreamReader(memoryStream);

            var json = await streamReader.ReadToEndAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task SaveAsync<T>(string fileName, T content)
        {
            var json = JsonConvert.SerializeObject(content);
            await File.WriteAllTextAsync(fileName, json);
        }
    }

    interface ISpaceStateRepository
    {
        Task AddAsync(Domain.SpaceStateAggregate.SpaceState spaceState);

        Task<Domain.SpaceStateAggregate.SpaceState> ReadAsync();
    }

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
