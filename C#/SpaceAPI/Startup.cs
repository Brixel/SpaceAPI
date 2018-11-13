﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
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
                RequiredScopes = new List<string>() { ConfigurationManager.AppSettings["SpaceAPIScope"] },
                
            });
            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions()
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidAudience = "https://brixelidentity.azurewebsites.net/resources",
                    ValidIssuer = "https://brixelidentity.azurewebsites.net",
                }
            });
            app.UseWebApi(config);

        }
    }
}
