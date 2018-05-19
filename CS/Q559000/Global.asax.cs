// Developer Express Code Central Example:
// GridView - How to implement date range filtering using a custom editor in the AutoFilterRow
// 
// This example demonstrates how to implement date range filtering in the GridView
// extension.
// Use the MVCxGridViewColumn.SetFilterTemplateContent
// (http://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxGridViewColumn_SetFilterTemplateContenttopic)
// method to create a custom editor and assign a delegate method to the
// GridViewSettings.ProcessColumnAutoFilter
// (http://documentation.devexpress.com/#AspNet/DevExpressWebMvcGridViewSettings_ProcessColumnAutoFiltertopic)
// property to process a custom filter expression sent from the client side.
// See
// also:
// http://www.devexpress.com/scid=E1990
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5038

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Q559000
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
			
			ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();
        }
    }
}