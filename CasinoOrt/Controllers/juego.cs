using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoOrt.Controllers
{
    public class juego : Controller
    {
        public IActionResult blackjack()
        {
            return View();
        }

        public IActionResult tragamoneda()
        {
            return View();
        }

        public IActionResult paginaPrincipal()
        {
            
            return View();
        }
    }
}
