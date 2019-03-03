using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lesson2()
        {
            string[] balloons = { "red", "green", "blue" };
            ViewBag.balloons = balloons;
            return View();
        }

        public ActionResult Lesson3(String color)
        {
            ViewBag.Color = color;
            return View();
        }

        public ActionResult AddNumbers(FormCollection form)
        {
            double num1, num2;

            if (Double.TryParse(form["num1"], out num1) && Double.TryParse(form["num2"], out num2))
            {
                ViewBag.Total = num1 + num2;
            }
            else
            {
                ViewBag.Total = "Invaild";
            }

            return View();
        }
    }
}