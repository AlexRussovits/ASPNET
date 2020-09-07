using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praktika1.Models;

namespace Praktika1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string name = "World";
            ViewBag.Hello = "Tere, "+ name;

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Tere hommikust" : "Tere päevast";



            return View();
        }

        public string Start()
        {

            return "Hello, World!";
        }

        [HttpGet]//show the form
        public ViewResult RegisterForm()
        {

            return View();
        }

        [HttpPost] //accept data from the form
        public ViewResult RegisterForm(QuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}