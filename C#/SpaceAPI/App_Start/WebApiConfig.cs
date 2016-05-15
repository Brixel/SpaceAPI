
using System.Web.Http;

namespace SpaceAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            AddRoutes(config);
        }

        private static void AddRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
             name: "API Default",
             routeTemplate: "api/{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional });
        }
    }
}
