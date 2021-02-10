using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2021.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // http://localhost:5000/Dog/Pozdrav?NekiBroj=5
        public IActionResult Pozdrav(int NekiBroj = 1)
        {
            // neke varijable koje bacamo na view
            ViewData["Poruka"] = "Uplati  mi na racun";
            ViewData["NekiBroj"] = NekiBroj;


            string model = "pozdrav svijete iz MVC-a!";
            return View((object)model); //Views/Dog/Pozdrav.cshtml
        }
    }
}
