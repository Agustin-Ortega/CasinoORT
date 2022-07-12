using CasinoOrt.Context;
using CasinoOrt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoOrt.Controllers
{
    public class HomeController : Controller
    {

        private readonly CasinoContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password))
                {
                    var user = _context.usuarios.FirstOrDefault(e => e.nombreUsuario == usuario && e.contraseña == password);


                    if (user != null)
                    {
                    HttpContext.Session.SetString("usuario",usuario);
                    //return RedirectToAction(nameof(Login));
                    return RedirectToAction("Index" , "Home");

                }
                    else
                    {
                        return RedirectToAction("Login");
                    }

                }
                else
                {
                    return RedirectToAction("Login");
                }

            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

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
