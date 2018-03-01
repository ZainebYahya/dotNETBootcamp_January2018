using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TestAPIs2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Starwars()
        {
            return View();
        }


        public ActionResult ShowInfoForPlanet(string ID)
        {

            HttpWebRequest request = WebRequest.CreateHttp("https://swapi.co/api/planets/" +ID);

            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

            //  request.Headers

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader rd = new StreamReader(response.GetResponseStream());

                string output = rd.ReadToEnd();// read all the response back. 

                // parsing the data (Todo)

                JObject JParser = JObject.Parse(output);


                ViewBag.RawData = JParser["name"];

                ViewBag.RInfo = JParser["residents"];

                return View("ShowResults");


            }

            else // we have something wrong 
            {

                return View("../Shared/Error");
            }

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
    }
}