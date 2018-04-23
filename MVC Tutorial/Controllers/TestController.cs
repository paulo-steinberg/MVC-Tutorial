using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Name = "Steinberg";
            List<string> list = new List<string>();
            list.Add("Steinberg");
            list.Add("Vinicius");
            list.Add("Correard");


            ViewBag.NameList = list;
            return View();
        }
    }
}