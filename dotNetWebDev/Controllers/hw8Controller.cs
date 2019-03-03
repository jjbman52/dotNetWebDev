using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class hw8Controller : Controller
    {
        // GET: homework8
        public ActionResult homework8(String name = "Unknown", int age = -1, String color = "N/A")
        {
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.color = color;

            return View();
        }
    }
}