using System.Linq;
using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Infrastructure;

class SpaceStateRepository : ISpaceStateRepository
{
    private readonly SpaceStateContext _context;

    public SpaceStateRepository(SpaceStateContext context)
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