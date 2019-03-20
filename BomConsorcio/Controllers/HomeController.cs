using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomConsorcio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard(bool? Ajax)
        {
            if (Ajax.HasValue && Ajax.Value)
            {
                return View("Dashboard", "_AjaxLayout");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Clientes()
        {
            return View();
        }
    }
}