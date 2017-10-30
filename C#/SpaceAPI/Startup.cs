using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SpaceAPI.Startup))]

namespace SpaceAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions()
            {
                Authority = ConfigurationManager.AppSettings.Get("IdentityServiceURL"),
                RequiredScopes = new[] {"api"}
            });
            app.UseWebApi(config);

        }
    }
}
