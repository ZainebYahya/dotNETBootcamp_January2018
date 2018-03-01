using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestIdentity2018.Models;
using Microsoft.AspNet.Identity;

namespace TestIdentity2018.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {    
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

       // [Authorize(Roles ="admin")]
        public ActionResult About()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Message = $"Your ID = {User.Identity.Name}";
                //1. ORM 
                ApplicationDbContext ORM = new ApplicationDbContext();

                ApplicationUser currentUser = ORM.Users.Find(User.Identity.GetUserId());

            }

            return View();
        }

       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}