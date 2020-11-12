using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC_Assignment1.Controllers
{
    public class TempController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
