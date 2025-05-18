using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
            Palabrabd.IniciarJuego();
            ViewBag.palabra = Palabrabd.PalabraAAdivinar;
            ViewBag.LetrasUtilizadas = Palabrabd.LetrasUtilizadas;
            ViewBag.Intentos = Palabrabd.IntentosLetras;
            ViewBag.PalabraOculta = Palabrabd.PalabraOculta;
            return View("Index");
        
    }
    public IActionResult IngresarLetras(char letra)
    {
        Palabrabd.VerificarLetra(letra);
        ViewBag.palabra = Palabrabd.PalabraAAdivinar;
        ViewBag.LetrasUtilizadas = Palabrabd.LetrasUtilizadas;
        ViewBag.Intentos = Palabrabd.IntentosLetras;
        ViewBag.PalabraOculta = Palabrabd.PalabraOculta;

       if(Palabrabd.PalabraOculta==Palabrabd.PalabraAAdivinar)
       {
            return View("Ganaste");
       }
       if(Palabrabd.IntentosLetras==7)
       {
           return View("Perdiste");
       }

        return View("Index");
    }
    public IActionResult IngresarPalabras(string palabra)
    {
        Palabrabd.VerificarPalabra(palabra);
        ViewBag.palabra = Palabrabd.PalabraAAdivinar;
        ViewBag.LetrasUtilizadas = Palabrabd.LetrasUtilizadas;
        ViewBag.Intentos = Palabrabd.IntentosLetras;
        ViewBag.PalabraOculta = Palabrabd.PalabraOculta;
        if (Palabrabd.PalabraAAdivinar == palabra)
        {
            return View("Ganaste");
        }
        else
        {
            return View("Perdiste");
        }       
    }
    

}
