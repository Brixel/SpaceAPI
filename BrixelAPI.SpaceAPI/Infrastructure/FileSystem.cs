using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BrixelAPI.SpaceState.Infrastructure
{
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
}