using BrixelAPI.SpaceState.Domain;
using BrixelAPI.SpaceState.Features.UpdateState;
using BrixelAPI.SpaceState.Infrastructure;
using FluentValidation;
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
            serviceCollection.AddScoped<ISpaceStateChangedLogRepository, SpaceStateChangedLogRepository>();
            serviceCollection.AddScoped<ISpaceStateUnitOfWork, SpaceStateUnitOfWork>();
            serviceCollection.AddScoped<IFileSystem, FileSystem>();
            
        }
    }
}
