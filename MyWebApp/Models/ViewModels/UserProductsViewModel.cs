using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models.ViewModels
{
    public class UserProductsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }        
        public string ProudctName { get; set; }
        public decimal price { get; set; }

        public Product Product { get; set; }

    }
}