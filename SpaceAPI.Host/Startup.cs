using BrixelAPI.SpaceState;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            //services.AddDbContext<LogContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("SpaceAPIConnection")));
            //services.AddScoped<IServerLessRequestService, ServerLessRequestService>();
            //services.Configure<ServerLessOptions>(Configuration.GetSection("ServerLessOptions"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers(options =>
            {
                options.RespectBrowserAcceptHeader = true;
            });

            services.AddSwaggerGen(c =>
            {
                //c.CustomSchemaIds(type => type.ToString());
            });
            services.AddMvcCore()
                .AddApiExplorer();

            ConfigureVerticals(services, Configuration);
        }

        private void ConfigureVerticals(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            Bootstrapper.Configure(serviceCollection, configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brixel.SpaceAPI");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class ServerLessOptions
    {
        public string FunctionBaseUri { get; set; }
        public string SpaceStateChangedUri { get; set; }
    }
}
