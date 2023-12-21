using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SuperCars.Models;
using cars;
namespace SuperCars.Controllers;

public class ScarsController : Controller
{
    private readonly ILogger<ScarsController> _logger;

    public ScarsController(ILogger<ScarsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Scars()
    {
        Scars sc = new Scars();
        sc.Brand = "Pagani";
        sc.Name="Zonda";
        sc.Model="PZ-6969";
        sc.Price ="$ 1,500,000";
        ViewData["Cars"] = sc;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
