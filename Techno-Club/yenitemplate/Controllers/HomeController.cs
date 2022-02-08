using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using yenitemplate.Models;

namespace yenitemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult bizKimiz()
        {
            return View();
        }
        public IActionResult bloglar()
        {
            return View();
        }

        public IActionResult gelismeler()
        {
            return View();
        }


        public IActionResult Iletisim()
        {
            return View();
        }

        public IActionResult blog1()
        {
            return View();
        }
        public IActionResult blog2()
        {
            return View();
        }

        public IActionResult blog3()
        {
            return View();
        }

        public IActionResult blog4()
        {
            return View();
        }
        public IActionResult blog5()
        {
            return View();
        }

        public IActionResult gelismeler1()
        {
            return View();
        }
        public IActionResult gelismeler2()
        {
            return View();
        }

        public IActionResult gelismeler3()
        {
            return View();
        }

        public IActionResult gelismeler4()
        {
            return View();
        }

        public IActionResult gelismeler5()
        {
            return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
