using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_lab1.Controllers
{
    public class HomeController : Controller
    {
        //class employee
        public class User
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public String Email { get; set; }
            public String Phone { get; set; }
        }

      [HttpPost]
        public ViewResult Register(User user)
        {
            if (user != null && user.Name != null && user.Email != null)
            {
                ViewBag.Name = user.Name;
                return View("Welcome");

            }

            return View();

        }


        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
    }
}