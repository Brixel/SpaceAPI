using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate
{
    public class SpaceStateChangedLogEntityTypeConfiguration : IEntityTypeConfiguration<SpaceStateChangedLog>
    {
        public void Configure(EntityTypeBuilder<SpaceStateChangedLog> builder)
        {
            builder
                .Property(x => x.IsOpen)
                .IsRequired();
            builder
                .Property(x => x.ChangedByUser)
                .IsRequired();
            builder
                .Property(x => x.ChangedAtDateTime)
                .IsRequired();

            builder
                .HasIndex(x => new
                {
                    x.IsOpen,
                    x.ChangedAtDateTime,
                    x.ChangedByUser
                })
                .IsUnique();
        }
    }
}