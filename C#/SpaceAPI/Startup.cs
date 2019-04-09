using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Owin;
using SpaceAPI.Controllers.Resolvers;

[assembly: OwinStartup(typeof(SpaceAPI.Startup))]

namespace SpaceAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new LowerCaseContractResolver()
            };
            WebApiConfig.Register(config);
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions()
            {
                AuthenticationType = "Bearer",
                Authority = ConfigurationManager.AppSettings.Get("IdentityServiceURL"),
                RequiredScopes = new List<string>() { ConfigurationManager.AppSettings["SpaceAPIScope"] },
                ValidationMode = ValidationMode.Local
            });
            app.UseWebApi(config);

        }
    }
}
