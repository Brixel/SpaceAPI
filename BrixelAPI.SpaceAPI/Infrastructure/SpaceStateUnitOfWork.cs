using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Infrastructure
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