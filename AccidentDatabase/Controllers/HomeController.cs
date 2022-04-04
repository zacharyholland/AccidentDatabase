using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccidentDatabase.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Accidents()
        {
            var x = repo.Accidents
                .ToList();

            return View();
        }

        public IActionResult Data()
        {
            return View();
        }
    }
}
