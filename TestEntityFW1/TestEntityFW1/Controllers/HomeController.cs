using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestEntityFW1.Models;

namespace TestEntityFW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddNewCustomer(Customer newCustomer)
        {
            // 1. Create an object from the ORM class 
            NorthwindEntities MyORM = new NorthwindEntities();
           // validation!!!!
            MyORM.Customers.Add(newCustomer);

            MyORM.SaveChanges();

            return View("Index");
        }
    }
}