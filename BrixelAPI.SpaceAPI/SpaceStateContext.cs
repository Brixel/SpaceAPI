using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState
{
    public class SpaceStateContext : DbContext
    {
        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }

        public SpaceStateContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SpaceStateChangedLogEntityTypeConfiguration());
        }
    }
}