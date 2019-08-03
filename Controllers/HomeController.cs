using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Institucion_Educativa_Tumac.Models;

namespace Institucion_Educativa_Tumac.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult Instalacion()
        {
            return View();
        }

        public IActionResult Comedor()
        {
            return View();
        }

        public IActionResult Uniformes()
        {
            return View();
        }

        public IActionResult Ampa()
        {
            return View();
        }

        public IActionResult Horarios()
        {
            return View();
        }

        public IActionResult Act_Extraescolares()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Por_Tumac()
        {
            return View();
        }

        public IActionResult Modo_Manera()
        {
            return View();
        }

        public IActionResult Mision()
        {
            return View();
        }

        public IActionResult Historia()
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
