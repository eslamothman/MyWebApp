using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Insert()        
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Employee newEmployee)
        {
            MyData mydatabase = new MyData();
            mydatabase.Employees.Add(newEmployee);
            mydatabase.SaveChanges();
            return Content("Employee Inserted Successfully");
        }



    }
}