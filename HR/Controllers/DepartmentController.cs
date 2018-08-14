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
        private object mydata;

        // GET: Department
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Department NewDepartment)
        {
            MyData Departmentdata = new MyData();

            Departmentdata.Departments.Add(NewDepartment);
            Departmentdata.SaveChanges();
            return Content("Department Inserted Successfully");
        }
    }
}