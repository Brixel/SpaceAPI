using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Infrastructure.Migrations
{
    [ApiController]
    [Route("api/brixel/migrations")]
    public class MigrationsController : ControllerBase
    {
        private readonly SpaceStateContext _context;

        public MigrationsController(SpaceStateContext context)
        {
            _context = context;
        }

        [HttpPost("migrate")]
        public async Task Migrate(CancellationToken cancellationToken)
        {
            await _context.Database.MigrateAsync(cancellationToken);
        }
    }
}
