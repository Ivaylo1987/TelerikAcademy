﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace Application.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Comments",
                routeTemplate: "api/articles/{id}/comments",
                defaults: new
                {
                    controller = "Comments"
                }
            );

            config.Routes.MapHttpRoute(
                name: "Likes",
                routeTemplate: "api/articles/like/{id}",
                defaults: new
                {
                    controller = "Likes"
                }
            );

            var cros = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cros);
        }
    }
}
