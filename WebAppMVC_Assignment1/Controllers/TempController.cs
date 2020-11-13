using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC_Assignment1.Models;

namespace WebAppMVC_Assignment1.Controllers
{
    public class TempController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(string BodyTemp)
        {
            String recommendation=Doctor.giveRecomendation(Convert.ToDouble(BodyTemp));

            ViewBag.Recommendation = recommendation;

            //return RedirectToAction(nameof(FeverCheck));
            return View();
        }
    }
}
