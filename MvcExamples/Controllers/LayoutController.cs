using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamples.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult _LayoutView()
        {
            return View();
        }
        public ActionResult Layout1View()
        {
            return View();
        }
        public ActionResult NullView()
        {
            return View();
        }
    }
}