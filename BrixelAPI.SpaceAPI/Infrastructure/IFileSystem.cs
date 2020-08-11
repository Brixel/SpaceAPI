using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
{
    interface IFileSystem
    {
        Task<T> ReadAsync<T>(string fileName);

        Task SaveAsync<T>(string fileName, T content);
    }
}