using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task21_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> lst= new List<string>();
            lst.Add("Rose");
            lst.Add("Jasmine");
            lst.Add("Tulips");
            lst.Add("Sunflowers");
            lst.Add("Lotus");
            lst.Add("Lily");
            ViewBag.Flowerlst = lst;
            return View();
        }

        public ActionResult GetText(string rdFlower)
        {
            ViewBag.Output = "Your favourite flower is: " + rdFlower;
            List<string> lst = new List<string>();
            lst.Add("Rose");
            lst.Add("Jasmine");
            lst.Add("Tulips");
            lst.Add("Sunflowers");
            lst.Add("Lotus");
            lst.Add("Lily");
            ViewBag.Flowerlst = lst;
            return View("Index");
        }

    }
}