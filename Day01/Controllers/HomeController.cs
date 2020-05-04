using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day01.Controllers
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Register()
        {
            return View("RegisterationForm");
        }

        [HttpPost]
        public ViewResult Register(Person person)
        {
            if (person != null && person.Name != null && person.Email != null)
            {
                ViewBag.Name = person.Name;
                return View("Welcome");
            }
            return View("RegisterationForm");
        }

        [HttpGet]
        public ViewResult Welcome()
        {
            return View();
        }
    }
}