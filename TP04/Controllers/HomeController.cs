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
        string palabra=Palabrabd.IniciarPalabra();
        int Intentos=Palabrabd.IntentosLetras;
        List<char> letrasUtilizadas=Palabrabd.LetrasUtilizadas;
        ViewBag.palabra=palabra;
        ViewBag.letrasUtilizadas=letrasUtilizadas;
        
        return View();
    }
    public IActionResult IngresarLetras(char letra)
    {
        List<int> PosicionesLetras=Palabrabd.VerificarLetra(letra);
        ViewBag.PosicionesLetras=PosicionesLetras;
        return View("Index");
    }
    public IActionResult IngresarPalabras(string palabra)
    {
        bool laPalabraEsCorrecta=Palabrabd.VerificarPalabra(palabra);
        ViewBag.laPalabraEsCorrecta=laPalabraEsCorrecta;
        return View("Index");
    }
    

}
