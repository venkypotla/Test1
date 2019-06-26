using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGITEXAMPLE.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
           ViewBag.Name="venky";
           ViewBag.Age=23
            return View();
        }
    }
}
