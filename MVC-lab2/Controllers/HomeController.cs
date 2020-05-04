using MVC_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_lab2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var ctx = new ModelContext();
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
                return View("employee", employee);
            }
            return View();


        }
    }
}