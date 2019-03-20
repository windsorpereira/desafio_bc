using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomConsorcio.Controllers
{
    public class PortesController : Controller
    {
        public ActionResult Index()
        {
            return View("Portes", "_AjaxLayout");
        }
    }
}