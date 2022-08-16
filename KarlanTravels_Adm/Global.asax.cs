﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using KarlanTravels_Adm.Models;
using KarlanTravels_Adm.Controllers;
using System.Data.Entity;

namespace KarlanTravels_Adm
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected void Application_End(object sender, EventArgs e)
        //{
        //    SessionCheck SesCheck = new SessionCheck();
        //    if (SesCheck.SessionChecking())
        //    {
        //        ContextModel db = new ContextModel();
        //        Admin adm = db.Admin.Find(Session["CurrentAdminId"]);
        //        adm.IsActive = false;
        //        db.Entry(adm).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}
    }
}