using BrixelAPI.SpaceState.Domain;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using BrixelAPI.SpaceState.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrixelAPI.SpaceState
{
    public class Bootstrapper
    {
        public static void Configure(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddMediatR(typeof(Bootstrapper).Assembly);


            serviceCollection.AddScoped<ISpaceStateRepository, SpaceStateRepository>();
            serviceCollection.AddScoped<IFileSystem, FileSystem>();

            serviceCollection.AddDbContext<SpaceStateContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SpaceAPIConnection")));
        }
    }

    public class SpaceStateContext : DbContext
    {
        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }

        public SpaceStateContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
    }
}
