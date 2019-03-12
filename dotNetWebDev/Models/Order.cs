using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetWebDev.Models
{
    public class Order
    {
        public Product Prod { get; set; }
        public int Qty { get; set; }
    }
}