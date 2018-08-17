using HR.DatabaseFirstModel;
using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class BranchesController : Controller
    {
        public ActionResult Insert()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Branche NewBranches)
        {
            MyDatabaseContext Branchestdata = new MyDatabaseContext();

            Branchestdata.Branches.Add(NewBranches);
            Branchestdata.SaveChanges();
            return Content("Branchest Inserted Successfully");
        }
    }
}