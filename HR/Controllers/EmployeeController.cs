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
            MyData mydatabase = new MyData();
            //List<Department> departments = mydatabase.Departments.ToList(); 

            List<Department> departments = new List<Department>();

            var FirstDepartment = new Department() { Id = 1, DeprtName = "HR" };
            var SecondDepartment = new Department() { Id = 2, DeprtName = "Marketing" };
            var ThirdDepartment = new Department() { Id = 3, DeprtName = "Sales" };

            departments.Add(FirstDepartment);
            departments.Add(SecondDepartment);
            departments.Add(ThirdDepartment);

            ViewBag.Departments = new SelectList(departments, "Id", "DeprtName" ) { };
            

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