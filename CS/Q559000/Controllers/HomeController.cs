using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;

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
