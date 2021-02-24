using System;
using Microsoft.AspNetCore.Mvc;


namespace _4_01_vj.Controllers
{
    public class BrojGodinaController : Controller
    {
        public IActionResult RacunajBrojGodina()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RacunajBrojGodina(DateTime datum)
        {
            int brojGodina;
            try
            {
                brojGodina = (DateTime.Now - datum).Days / 365;
                return View((object)brojGodina.ToString());
            }
            catch (Exception e)
            {
                return View((object)e.Message);                
            }
        }
    }
}