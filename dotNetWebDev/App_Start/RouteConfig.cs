using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dotNetWebDev
{
        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "hw2",
                    url: "{controller}/{action}",
                    defaults: new { controller = "Home", action = "hw2"}
                );

            routes.MapRoute(
                    name: "hw8",
                    url: "{controller}/{action}/{name}/{age}/{color}",
                    defaults: new { controller = "hw8", action = "homework8", name = UrlParameter.Optional, age = UrlParameter.Optional, color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "color",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "HW10", action = "colorCombinator", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "Lesson3",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "Home", action = "Lesson3", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            }
        }
    }

