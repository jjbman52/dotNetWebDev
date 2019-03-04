using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class HW10Controller : Controller
    {
        // GET: HW10
        public ActionResult Index()
        {
            return View();
        }
            public ActionResult colorCombinator(FormCollection form)
        {
            String color1, color2;

            color1 = form["color1"];
            color2 = form["color2"];
            

            if (color1 == "red" && color2 == "red")
            {
                ViewBag.Color = "Red";
            }
            else if (color1 == "green" && color2 == "green")
            {
                ViewBag.Color = "Green";
            }
            else if (color1 == "blue" && color2 == "blue")
            {
                ViewBag.Color = "Blue";
            }
            else if (color1 == "red" && color2 == "green" || color2 == "red" && color1 == "green")
            {
                ViewBag.Color = "Yellow";
            }
            else if (color1 == "red" && color2 == "blue" || color2 == "red" && color1 == "blue")
            {
                ViewBag.Color = "Purple";
            }
            else if (color1 == "green" && color2 == "blue" || color2 == "green" && color1 == "blue")
            {
                ViewBag.Color = "Cyan";
            }
            else
            {
                ViewBag.Color = "Invailid";
            }


            return View();
        }
    }
}