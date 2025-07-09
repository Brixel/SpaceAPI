using BrixelAPI.SpaceState;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace SpaceAPI.Host
{
    public static class WebApplicationBuilder
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var version = GetVersion();

            var configurationSection = configuration.GetSection(nameof(AuthConfig));
            var authConfiguration = configurationSection.Get<AuthConfig>();
            services.Configure<AuthConfig>(configurationSection);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers(options =>
            {
                options.RespectBrowserAcceptHeader = true;
            }).AddJsonOptions(o =>
            {
                o.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            });


            AddAuthentication(services, authConfiguration);
            AddAuthorization(services);
            AddCors(services);
            AddOpenAPI(services, version);

            ConfigureVerticals(services, configuration);
        }

        private static void AddOpenAPI(IServiceCollection services, string version)
        {
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
        }

        private static void AddCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });
        }

        private static void AddAuthorization(IServiceCollection services)
        {
            services.AddAuthorization(auth =>
            {
                var defaultPolicy =
                    new AuthorizationPolicyBuilder()
                        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                        .RequireAuthenticatedUser()
                        .Build();

                auth.DefaultPolicy = defaultPolicy;
            });
        }

        private static void AddAuthentication(IServiceCollection services, AuthConfig authConfiguration)
        {
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
        }

        private static string GetVersion()
        {
            return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

        }

        private static void ConfigureVerticals(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            Bootstrapper.Configure(serviceCollection, configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseCors();

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
