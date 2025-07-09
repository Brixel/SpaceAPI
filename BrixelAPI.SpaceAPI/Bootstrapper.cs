using BrixelAPI.SpaceState.Features.UpdateState;
using BrixelAPI.SpaceState.Infrastructure;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrixelAPI.SpaceState
{
    public static class Bootstrapper
    {
        public static void Configure(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(Bootstrapper).Assembly));

            serviceCollection.AddScoped<ISpaceStateRepository, SpaceStateRepository>();
            serviceCollection.AddScoped<ISpaceStateUnitOfWork, SpaceStateUnitOfWork>();

            serviceCollection.AddDbContext<SpaceStateContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SpaceAPIConnection")));

            serviceCollection.AddValidatorsFromAssemblyContaining<ToggleIsOpenStateRequestValidator>();
        }
    }
}
