using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validation.Models;
// using BOL;
using BLL;

namespace Validation.Controllers;

public class EmployeeController : Controller
{
  private readonly ILogger<EmployeeController> _logger;

  public EmployeeController(ILogger<EmployeeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Login()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Login(string email, string password)
  {
    EmployeeManager e = new EmployeeManager();
    bool status = e.Validate(email, password);
    if (status)
    {
      return this.RedirectToAction("Products", "Products");
    }
    return View();
  }
}
