using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Portfolio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
                name: "CSharp",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CSharp", action = "Examples", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Web Design",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "WebDesign", action = "Examples", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Web Development",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "WebDevelopment", action = "Examples", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
