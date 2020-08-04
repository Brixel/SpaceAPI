using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BrixelAPI.SpaceAPI
{
    public class Bootstrapper
    {
        public static void Configure(IServiceCollection serviceCollection)
        {


            serviceCollection.AddMediatR(typeof(Bootstrapper));
        }
    }
}
