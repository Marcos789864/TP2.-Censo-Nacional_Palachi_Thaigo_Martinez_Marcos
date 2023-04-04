using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP2._Censo_Nacional_Palachi_Thaigo_Martinez_Marcos.Models;

namespace TP2._Censo_Nacional_Palachi_Thaigo_Martinez_Marcos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
