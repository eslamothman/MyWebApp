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
            MyDatabaseContext mydatabase = new MyDatabaseContext();
            List<Department> departments = mydatabase.Departments.ToList();
            ViewBag.Departments = new SelectList(departments, "Id", "DeprtName") { };

            List<Branche> Branches = mydatabase.Branches.ToList();
            ViewBag.Branches = new SelectList(Branches, "BrancheId", "BranchesName") { };

            return View();
        }
        [HttpPost]
        public ActionResult Insert(Employee newEmployee)
        {
            MyDatabaseContext mydatabase = new MyDatabaseContext();
            mydatabase.Employees.Add(newEmployee);
            mydatabase.SaveChanges();
            return Content("Employee Inserted Successfully");
        }

        public ActionResult Index()
        {
            MyDatabaseContext context = new MyDatabaseContext();
            var allEmployees = context.Employees.ToList();
            return View(allEmployees);
        }

        public ActionResult Details(int id)
        {
            MyDatabaseContext context = new MyDatabaseContext();
            var AllEmployees = context.Employees.ToList();

            Employee selectedEmployee = null;
            foreach (Employee item in AllEmployees)
            {
                if (item.Id == id)
                {
                    selectedEmployee = item;
                    break;
                }
            }
            return View(selectedEmployee);
        }



    }
}