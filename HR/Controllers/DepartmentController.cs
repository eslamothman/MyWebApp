using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Department NewDepartment)
        {
            MyDatabaseContext Departmentdata = new MyDatabaseContext();

            Departmentdata.Departments.Add(NewDepartment);
            Departmentdata.SaveChanges();
            return Content("Department Inserted Successfully");
        }
    }
}