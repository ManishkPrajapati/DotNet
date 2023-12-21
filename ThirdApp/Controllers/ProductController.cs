using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThirdApp.Models;
using catalog;

namespace ThirdApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult catalog()
    {
        Product p1= new Product();
        p1.Title="Computer";
        p1.Description="New GEneration";
        p1.UnitPrice = 70000;
        p1.Quantity =999;
        p1.Image ="/images/download.jpeg";
        ViewData["computer"] = p1;
        return View();





    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
