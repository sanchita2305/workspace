using Microsoft.AspNetCore.Mvc;
using ProdMvc.Models;
namespace ProdMvc.Controllers;
public class ProductController:Controller{
    private readonly SanchitaaContext context;
    public ProductController(SanchitaaContext _context) //dependency injection
    {
      context= _context;
    }
    public IActionResult List()
    {
        var data=context.Product.ToList();
        return View(data);
    }
    public IActionResult Display(int id)
    {
        var data=context.Product.Find(id);
        return View(data);
    }
    public IActionResult Create()
    {
        return View();
    }
  [HttpPost]
  public IActionResult Create(Product prod)
  {
     if(ModelState.IsValid)
     {
        context.Product.Add(prod);
        context.SaveChanges();
        return RedirectToAction("List");

     }
     return View();
  }
  public IActionResult Edit(int id)
  {
   var data=context.Product.Find(id);
   return View(data);
  }
  [HttpPost]
  public IActionResult Edit(Product prod)
  {
    if(ModelState.IsValid)
    {
        Product product=context.Product.Find(prod.Id);
        product.Name=prod.Name;
        product.Price=prod.Price;
        product.Stock=prod.Stock;
        context.SaveChanges();
        return RedirectToAction("List");
    }
    return View();
  }
   public IActionResult Delete(int id)
    {
        var data=context.Product.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Delete(Product prod)
    {
        context.Product.Remove(prod);
        context.SaveChanges();
        return RedirectToAction("List");
    }

}