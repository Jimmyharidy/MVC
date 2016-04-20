﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Uppgift1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes) // test test
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CompanyController",
                url: "Company/{action}/{id}",
                defaults: new { controller = "Company", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "SellController",
                url: "Sell/{action}/{id}",
                defaults: new { controller = "Sell", action = "B2B", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "LifeController",
               url: "Life/{action}/{id}",
               defaults: new { controller = "Life", action = "SuperMario", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "LaserController",
              url: "Laser/{action}/{id}",
              defaults: new { controller = "Laser", action = "Sabel", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
