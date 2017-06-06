using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Controllers
{
    public class HomeController : Controller
    {

        ContexDB db = new ContexDB();
        public ActionResult Index()
        {
            var user = db.Users.ToList();
            ViewBag.user = user;
            return View();
        }
    }
}
