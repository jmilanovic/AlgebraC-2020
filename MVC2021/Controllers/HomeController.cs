using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC2021.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /**
      * \Views\Home\Index.cshtml 
      */
        public IActionResult Index()  // defaultni action
        {
            return View();
        }
        /**
         * \Views\Home\Privacy.cshtml 
         */

        public IActionResult Privacy()  
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
