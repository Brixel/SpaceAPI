using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    class SpaceStateUnitOfWork : ISpaceStateUnitOfWork
    {
        private readonly SpaceStateContext _context;

        public SpaceStateUnitOfWork(SpaceStateContext context)
        {
            _context = context;
        }

        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}