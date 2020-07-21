using MvcExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamples.Controllers
{
    public class ViewOverloadsController : Controller
    {
        public ActionResult MyView()
        {
            PersonModel model = new PersonModel
            {
                Name = "John",
                Age = 25
            };

            //return View();
            //return View(model);
            //return View("~/Views/ViewOverloads/MyView.cshtml");
            //return View("~/Views/ViewOverloads/MyView.cshtml", model);
            //return View("~/Views/MyViews/MyView.cshtml");
            return View("~/Views/MyViews/MyView.cshtml", model);
        }
    }
}