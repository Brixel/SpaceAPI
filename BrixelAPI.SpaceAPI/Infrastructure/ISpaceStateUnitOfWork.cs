using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
{
    internal interface ISpaceStateUnitOfWork
    {
        Task CommitAsync();
    }
}