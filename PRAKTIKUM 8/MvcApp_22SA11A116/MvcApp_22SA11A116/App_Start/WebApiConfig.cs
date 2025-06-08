using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApp_22SA11A116
{
    //22SA11A116
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "amikom/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
