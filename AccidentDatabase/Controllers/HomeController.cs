using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccidentDatabase.Models;

namespace AccidentDatabase.Controllers
{
    public class HomeController : Controller
    {
        private IAccidentRepository repo { get; set; }

        public HomeController(IAccidentRepository temp)
        {
            repo = temp;
        }

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
    }
}
