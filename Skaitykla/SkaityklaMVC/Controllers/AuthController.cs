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
        //Butent is tos formos, kai useris paspaus submit btn, per metoda "post" ateis duomenis.Juos patikrins ar tikrai atejo per post metoda (httpPost filtras).
        [HttpPost]
        //sumepinam i duomenu modeli ir patikrinam ar jis yra validus.
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
