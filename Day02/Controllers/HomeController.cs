using Day02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day02.Controllers
{
    public class HomeController : Controller
    {
        Model1 objDataContext = new Model1();

        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ViewResult Index(Employee employee)
        {
            //ModelState.Remove("Gender");
            if (ModelState.IsValid)
            {
                objDataContext.Employees.Add(employee);
                objDataContext.SaveChanges();
                return View("Welcome", objDataContext.Employees.ToList());
            }
            return View();
        }

        [HttpGet]
        public ViewResult Welcome()
        {
            return View(objDataContext.Employees.ToList());
        }
    }
}