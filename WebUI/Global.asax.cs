using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Domain.Entities;

namespace WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

			Database.SetInitializer<MiddleEarthContext>(new DropCreateDatabaseAlways<MiddleEarthContext>());

			// Forces initialization of database on model changes.
			using (var context = new MiddleEarthContext())
			{
				context.Database.Initialize(force: true);
			}
		}

    }
}
