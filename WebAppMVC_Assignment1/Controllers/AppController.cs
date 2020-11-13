using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebAppMVC_Assignment1.Controllers
{
    public class AppController : Controller
    {
        public IActionResult About()
        {
            HttpContext.Session.SetString("View", "App/About");
            return View();
        }
        public IActionResult Contact()
        {
            HttpContext.Session.SetString("View", "App/Contact");
            return View();
        }

        public IActionResult Projects()
        {
            HttpContext.Session.SetString("View", "App/Projects");
            return View();
        }
    }
}
