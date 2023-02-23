using AccountDotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountDotnet.Controllers
{
    public class HomeController : Controller
    {
        AccountDotnetEntities entities = new AccountDotnetEntities();
        public ActionResult Index()
        {
            var data = from t in entities.Accounts select t;
            return View(data.ToList());
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
    }
}