using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;

namespace BrixelAPI.SpaceState.Features.UpdateState
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
    }
}