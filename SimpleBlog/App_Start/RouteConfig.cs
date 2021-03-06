﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Areas.Admin.Controllers;

namespace SimpleBlog {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new {controller = "Auth", action = "Login"});

            routes.MapRoute("Home", "", new {controller = "Posts", action = "Index"});
        }
    }
}