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

            
            // 0. validation!
            if (!ModelState.IsValid)
            {
                //// over errors for each field in your model
                //foreach (ModelState s in ModelState.Values)
                //{
                //    foreach (ModelError r in s.Errors)
                //    {
                //      // indivisual errors for each field 

                //   // r.ErrorMessage

                //    }

                //}


                return View("../Shared/Error");// error page 

            }

            try
            {
                // 1. Create an object from the ORM class 
                NorthwindEntities MyORM = new NorthwindEntities();
                // validation!!!!
                MyORM.Customers.Add(newCustomer);

                MyORM.SaveChanges();// reflects changes done on the list to the actual db
                return View("Index");
            }

            catch (Exception e)
            {

               // ModelState.Values.Add(new ModelState());
           
                return View("../Shared/Error");// error page 

            }
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


        public ActionResult DeleteCustomerByCID(string CustomerID)
        {
            //1. ORM 
             NorthwindEntities ORM = new NorthwindEntities();

            //2. Find the customer, then remove from the list 
            // If the record has any dependency, delete that first! 

            ORM.Customers.Remove(ORM.Customers.Find(CustomerID));

            //3. Save changes!

            ORM.SaveChanges();
            // return View("CustomersPage");
            return RedirectToAction("CustomersPage");
        }

        public ActionResult UpdateCustomerByCID(string CustomerID)
        {
            //1. ORM 

            NorthwindEntities ORM = new NorthwindEntities();
            
            //2. Find that customer
            Customer ToBeUpdated = ORM.Customers.Find(CustomerID);

            // 3. Send data to the view 
            ViewBag.CustomerToBeUpdated = ToBeUpdated;

            return View("CustomerDetails");

        }

        public ActionResult SaveCustomerChanges(Customer NewCustomer)
        {
            // 0. Server side Validation! 

            if (!ModelState.IsValid)
            {
                
                return View("../Shared/Error");// error page 

            }


            //1. ORM
            NorthwindEntities ORM = new NorthwindEntities();

            //2. Find the customer 
            ORM.Entry(ORM.Customers.Find(NewCustomer.CustomerID)).
                CurrentValues.SetValues(NewCustomer);
            //3.
            ORM.SaveChanges();

 //4. Go to the customer view (before that, u need to load customers data)
            return RedirectToAction("CustomersPage");
        }
    }
}