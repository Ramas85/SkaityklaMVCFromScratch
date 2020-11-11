using Microsoft.AspNetCore.Mvc;
using SkaityklaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SkaityklaMVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Kas tas HttpPost? Kai susikurem AuthController ir susikurem Index View,Index View'e padarem registracijos forma.
        //Butent is tos formos, kai useris paspaus submit per metoda "post" ateis duomenis per post metoda cia yra filtras httpPost.
        [HttpPost]
        //sumepinam i duomenu modeli ir siunciam i 
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "Blogi prisijungimo duomenys";
                return View("~/Views/Auth/Index.cshtml");
            }
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
    }
}
