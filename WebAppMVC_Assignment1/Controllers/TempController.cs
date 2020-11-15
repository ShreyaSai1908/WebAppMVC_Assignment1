using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC_Assignment1.Models;
using Microsoft.AspNetCore.Http;

namespace WebAppMVC_Assignment1.Controllers
{
    public class TempController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            HttpContext.Session.SetString("View", "Temp/FeverCheck");
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(double BodyTemp)
        {
            HttpContext.Session.SetString("View", "Temp/FeverCheck");
            string recommendation=Doctor.giveRecomendation(BodyTemp);

            ViewBag.Recommendation = recommendation;

            //return RedirectToAction(nameof(FeverCheck));
            return View();
        }
    }
}
