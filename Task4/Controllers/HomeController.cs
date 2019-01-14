using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Friends()
        {
            ViewBag.Title = "Friends";

            return View();
        }

        public ActionResult Family()
        {
            ViewBag.Title = "Family";

            return View();
        }

        public ActionResult Photos()
        {
            return Redirect("~/web/index.html") ;
        }
    }
}