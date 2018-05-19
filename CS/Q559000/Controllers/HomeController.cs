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
using DevExpress.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

namespace Q559000.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        Q559000.Models.NorthwindDataContext db = new Q559000.Models.NorthwindDataContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.Orders;
            return PartialView("_GridViewPartial", model);
        }

    }
}
