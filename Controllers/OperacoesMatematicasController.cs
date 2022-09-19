using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers;

public class OperacoesMatematicasController : Controller
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Soma()
    {
        return View();
    }

    public IActionResult Subtracao()
    {
        return View();
    }

    public IActionResult Multiplicacao()
    {
        return View();
    }

    public IActionResult Divisao()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] double num1, [FromForm] double num2 ){
        
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;
        ViewData["resultado"] = num1 + num2;

        return View();
    }

    public IActionResult ResultadoSubtracao([FromForm] double num1, [FromForm] double num2 ){
        
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;
        ViewData["resultado"] = num1 - num2;

        return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] double num1, [FromForm] double num2 ){
        
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;
        ViewData["resultado"] = num1 * num2;

        return View();
    }

    public IActionResult ResultadoDivisao([FromForm] double num1, [FromForm] double num2 ){
        
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;
        ViewData["resultado"] = num1 / num2;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return Content("Erro");
    }
}
