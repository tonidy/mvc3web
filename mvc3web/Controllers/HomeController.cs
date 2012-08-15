using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc3web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //nambahin feature
            ViewBag.Message = "Welcome to ASP.NET MVC! feature#1 version";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
