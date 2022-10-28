using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using BrixelAPI.SpaceState;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

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
            var version = GetVersion();

            //services.AddDbContext<LogContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("SpaceAPIConnection")));
            //services.AddScoped<IServerLessRequestService, ServerLessRequestService>();
            //services.Configure<ServerLessOptions>(Configuration.GetSection("ServerLessOptions"));

            var configurationSection = Configuration.GetSection(nameof(AuthConfig));
            var authConfiguration = configurationSection.Get<AuthConfig>();
            services.Configure<AuthConfig>(configurationSection);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers(options =>
            {
                options.RespectBrowserAcceptHeader = true;
            });

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = authConfiguration.Authority;
                options.Audience = authConfiguration.Audience;
                //options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateAudience = false
                };
            });

            services.AddAuthorization(auth =>
            {
                var defaultPolicy =
                    new AuthorizationPolicyBuilder()
                        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                        .RequireAuthenticatedUser()
                        .Build();

                auth.DefaultPolicy = defaultPolicy;
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc($"v{version}", new OpenApiInfo()
                {
                    Version = version,
                    Title = "Brixel.SpaceAPI",
                    Description = "SpaceAPI of Brixel"
                });
                options.DocumentFilter<AdditionalParametersDocumentFilter>();
                options.CustomOperationIds(
                    d => (d.ActionDescriptor as ControllerActionDescriptor)?.ActionName);
            });
            services.AddMvcCore()
                .AddApiExplorer()
                .AddFluentValidation();

            ConfigureVerticals(services, Configuration);
        }

        private static string GetVersion()
        {
            return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

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
                c.SwaggerEndpoint($"/swagger/v{GetVersion()}/swagger.json", "Brixel.SpaceAPI");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class AuthConfig
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Authority { get; set; }
    }

    public class ServerLessOptions
    {
        public string FunctionBaseUri { get; set; }
        public string SpaceStateChangedUri { get; set; }
    }
}
