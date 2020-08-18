using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    internal interface ISpaceStateUnitOfWork
    {
        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }
        Task CommitAsync();
    }
}