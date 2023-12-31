using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validation.Models;
using BOL;
using BLL;

namespace Validation.Controllers;

public class ProductsController : Controller
{
  private readonly ILogger<ProductsController> _logger;

  public ProductsController(ILogger<ProductsController> logger)
  {
    _logger = logger;
  }

  public IActionResult Products()
  {
    ProductManager pd = new ProductManager();
    List<Products> prod = pd.GetAllProducts();
    ViewData["product"] = prod;
    return View();
  }

  public IActionResult Insert()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Insert(int Id, string Name, int Price)
  {
    ProductManager pd = new ProductManager();
    bool status = pd.AddProduct(Id, Name, Price);
    if (status)
    {
      return this.RedirectToAction("Products");
    }
    return View();
  }

  [Route("Products/Edit/{id}")]
  public IActionResult Edit(int id)
  {
    ProductManager pd = new ProductManager();
    Products prod = pd.GetProducts(id);
    return View(prod);
  }


  [HttpPost]
  [Route("Products/Edit/{Id}")]
  public IActionResult Edit(int Id, string Name, int Price)
  {
    ProductManager pd = new ProductManager();
    bool status = pd.EditProduct(Id, Name, Price);
    if (status)
    {
      return this.RedirectToAction("Products");
    }
    return View();
  }


  [Route("Products/Delete/{id}")]
  public IActionResult Delete(int id)
  {
    ProductManager pd = new ProductManager();
    bool status = pd.DeleteProducts(id);
    if (status)
    {
      return this.RedirectToAction("Products");
    }
    return View();
  }


  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
