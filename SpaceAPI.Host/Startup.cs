using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Host.Services;

namespace SpaceAPI.Host
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LogContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SpaceAPIConnection")));
            //services.AddScoped<IServerLessRequestService, ServerLessRequestService>();
            //services.Configure<ServerLessOptions>(Configuration.GetSection("ServerLessOptions"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers();

            ConfigureVerticals(services);
        }

        private void ConfigureVerticals(IServiceCollection serviceCollection)
        {
            BrixelAPI.SpaceAPI.Bootstrapper.Configure(serviceCollection);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            MigrateDatabase(app);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void MigrateDatabase(IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<LogContext>();
            context.Database.Migrate();
        }
    }

    public class ServerLessOptions
    {
        public string FunctionBaseUri { get; set; }
        public string SpaceStateChangedUri { get; set; }
    }
}
