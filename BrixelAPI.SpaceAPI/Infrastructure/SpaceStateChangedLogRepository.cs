using System.Linq;
using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using BrixelAPI.SpaceState.Features.UpdateState;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Infrastructure
{
    class SpaceStateChangedLogRepository : ISpaceStateChangedLogRepository
    {
        private readonly SpaceStateContext _context;

        public SpaceStateChangedLogRepository(SpaceStateContext context)
        {
            _context = context;
        }
        public async Task AddAsync(SpaceStateChangedLog spaceStateChangedLog)
        {
            await _context.SpaceStateChangedLog.AddAsync(spaceStateChangedLog);
        }

        public Task<SpaceStateChangedLog> GetLastLogAsync()
        {
            return 
                _context.SpaceStateChangedLog
                    .OrderByDescending(x => x.ChangedAtDateTime)
                    .FirstOrDefaultAsync();
        }
    }
}