using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers;

public class CalculadoraController : Controller
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Calculadora()
    {        
        return View();
    }
    
    public IActionResult ResultadoCalculadora([FromForm] double num1, [FromForm] double num2,[FromForm] int selectAction ){
        
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;

        switch (selectAction)
        {
            case 1:
                ViewData["resultado"] = num1 + num2;
                ViewData["action"] = "+";
                break;
            case 2:
                ViewData["resultado"] = num1 - num2;
                ViewData["action"] = "-";
                break;
            case 3:
                ViewData["resultado"] = num1 / num2;
                ViewData["action"] = "/";
                break;
            case 4:
                ViewData["resultado"] = num1 * num2;
                ViewData["action"] = "*";
                break;            
            default:
                break;
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return Content("Erro");
    }
}
