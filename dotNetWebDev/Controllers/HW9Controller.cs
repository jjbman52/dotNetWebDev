using dotNetWebDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebDev.Controllers
{
    public class HW9Controller : Controller
    {
        // GET: HW9
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult products()
        {
            return View();
        }

        public ActionResult discounts()
        {
            return View();
        }

        public ActionResult register()
        {
            return View();
        }

        public ActionResult signin()
        {
            return View();
        }

        public ActionResult account()
        {
            return View();
        }


        List<Product> Products = new List<Product>()
        {
            new Product { Id="100", Name="Bat", Price=9.99},
            new Product { Id="101", Name="Cookie", Price=7.22},
            new Product { Id="102", Name="Knife", Price=9.80},
            new Product { Id="103", Name="Watch", Price=6.99},
            new Product { Id="104", Name="Coke", Price=5.22},
            new Product { Id="105", Name="Pen", Price=4.80}
        };

        public ActionResult DisplayProducts()
        {
            return View(Products);
        }

        public ActionResult Results(FormCollection form)
        {
            Session session = new Session();
            session.Discount = 0;

            session.Name = form["fname"] + " " + form["lname"];
            session.Address = form["address"];

            List<Order> orders = new List<Order>();
            double total = 0.0;

            foreach (Product product in Products)
            {
                int qty;
                Int32.TryParse(form[product.Id], out qty);
                if (qty > 0)
                {
                    orders.Add(new Order { Prod = product, Qty = qty });
                    total += product.Price * qty;

                    if (product.Id == "102" && qty == 3)
                    {
                        session.Discount = 11.4;
                    }
                }
            }

            session.Orders = orders;

            if (session.Discount > 0)
            {
                total -= session.Discount;
            }

            session.Total = total;
            

            return View(session);
        }
    }
}