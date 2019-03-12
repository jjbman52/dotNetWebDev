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
                    name: "HW3",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "HW3", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW4",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "HW4", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW5",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "HW5", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW6",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "HW6", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "fooIndex",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Foo", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "Bar",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Foo", action = "Bar", id = UrlParameter.Optional }
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
                    name: "BirthdayOrder",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "BirthdayOrder", action = "Order", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9DisplayProducts",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "DisplayProducts", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9CustomerInfo",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "CustomerInfo", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9Results",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "Results", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9Account",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "account", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9Discounts",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "discounts", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9Register",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "register", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "HW9Signin",
                    url: "{controller}/{action}/{color}",
                    defaults: new { controller = "HW9", action = "signin", color = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            }
        }
    }

