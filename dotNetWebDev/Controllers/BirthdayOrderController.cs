using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class BirthdayOrderController : Controller
    {
        string[] balloons = { "Red", "Green", "Blue" };
        // GET: Birthday
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            ViewBag.balloons = balloons;
            return View();
        }

        public ActionResult Results(FormCollection form)
        {
            String name = form["name"];
            String birthday = form["birthday"];
            ViewBag.BallonOrderName = name;
            ViewBag.BallonOrderBirthday = birthday;

            List<string> list = new List<string>();

            foreach (var balloon in balloons)
            {
                bool isChecked = Convert.ToBoolean(form[balloon].Split(',')[0]);
                if (isChecked)
                {
                    list.Add(balloon);
                }
            }

            ViewBag.list = list;

            return View();
        }
    }
}