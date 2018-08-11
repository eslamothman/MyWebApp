using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Product
    {        
        public Guid Id { get; set; }
        public string ProudctName { get; set; }
        public decimal price { get; set; }      
        public decimal Tax { get; set; }
    }
}