using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class FooController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Foo
        public ActionResult Bar(FormCollection form)
        {
            ViewBag.Gum = form["gum"];

            return View();
        }
    }
}