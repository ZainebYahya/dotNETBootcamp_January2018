using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchContacts()
        {
            return View();
        }

        public ActionResult AddToEList(string UserEmail)
        {
            // this will be added to the DB! 

            ViewBag.Confirm = $"{UserEmail} has been added to the DB (JK)";

            //ViewData.Add("Confirm", $"{UserEmail} has been added to the DB (JK)");

            return View("Contact");
        }

        public ActionResult AboutGC()
        {
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.TodaysDate = DateTime.Now.ToLongDateString();

            return View();// View called About
        }

        public ActionResult Contact()
        {
            string[] Jokes = { "The joke is on you!",
                "Why was the stadium so cold? Because there were a lot of fans.",
                "My mom told me to follow my dreams, so I went back to sleep." };
            // db, api 

            Random r = new Random();

            ViewBag.Message = Jokes[r.Next(Jokes.Length)];

            return View();
        }

        public ActionResult SearchContactsByName(string ContactName)
        {
            string[] ContactList = { "James", "John", "Matt","Zaineb", "Chandra","Jose",
                    "Audrae","Everett","Faithe","Justin","Daniel","Danielle","Jacob"
            };// Fake DB 
            List<string> SearchResults = new List<string>();
            foreach (string Contact in ContactList)
            {
                if (Contact.ToLower().Contains(ContactName.ToLower()))
                {
                    SearchResults.Add(Contact);
                }
            }
            ViewBag.SearchResults = SearchResults;

            return View("SearchResults");


        }
    }
}