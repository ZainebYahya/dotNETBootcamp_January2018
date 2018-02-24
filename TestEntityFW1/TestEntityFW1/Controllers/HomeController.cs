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

            MyORM.SaveChanges();// reflects changes done on the list to the actual db
            


            return View("Index");
        }

        public ActionResult CustomersPage()
        {
            //1. ORM 

            NorthwindEntities NorthwindORM = new NorthwindEntities();

            // select * from customers 

            //2. load the data into the ViewBag
            ViewBag.CustomersData = NorthwindORM.Customers.ToList();

            return View();
        }



        public ActionResult GetCustomersByCountry(string Country)
        {
            // 1. ORM

            NorthwindEntities NorthwindORM = new NorthwindEntities();

            ViewBag.CustomersData =
                NorthwindORM.Customers.Where(x => x.Country == Country).ToList();
            
            return View("CustomersPage");

        }

        public ActionResult GetOrdersByCID(string CustomerID)
        {

            //1 . ORM
            NorthwindEntities NorthwindORM = new NorthwindEntities();

            //2. Find orders made by that customer 
            ViewBag.CustomerOrders
                =NorthwindORM.Customers.Find(CustomerID).Orders.ToList();

            return View("OrderDetails");

        }

    }
}