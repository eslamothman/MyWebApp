using MyWebApp.Models;
using MyWebApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User NewUser)
        {
            if (ModelState.IsValid)
                //Code to insert into db
                return View();
            else
                return Content("el model mosh valid yasta");


        }

        [HttpPost]
        public ActionResult CreateWithViewModel(UserProductsViewModel ViewModel)
        {





            return View();
        }

        private void InsertIntoDataBase(Product product)
        {
            throw new NotImplementedException();
        }

        public ActionResult GetById(int? id)
        {
            return Content("enta da5lt 3la get by id");
        }


        public ActionResult Edit(int id)
        {
            return View();
        }
   
    }
}