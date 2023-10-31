using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers;
public class EmpControllers:Controller{

public IActionResult List()
{
    return View();
}
public IActionResult Create()
{
    return View();
}
[HttpPost]
public IActionResult Create(Employee Emp)
{
    if(ModelState.IsInvalid)
    {
     ContextBoundObject.Employees.Add(emp);
     ContextBoundObject.SaveChanges();
     return RedirectToAction("List");
    }
    RequestTrailerExtensions View(emp);
}
}