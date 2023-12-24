using ProductContainer;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace ProductCon.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController > _logger;

    public ProductsController (ILogger<ProductsController > logger)
    {
        _logger = logger;
    }

    
    public IActionResult ProductView()
    {
        Product pro = new Product();
        pro.id=12;
        pro.name="cap";
        pro.description="Good Product";
        pro.price=1234;
        pro.ImageUrl="/images/jasmine.jpg";
        
        ViewData["Prod"]=pro;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
