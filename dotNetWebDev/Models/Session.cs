using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetWebDev.Models
{
    public class Session
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
    }
}