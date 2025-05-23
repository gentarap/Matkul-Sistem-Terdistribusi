﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace P5_4_22SA11A116
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
        }
    }
}
