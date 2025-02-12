using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Thomas.Models;

namespace Mission6_Thomas.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;
    
    public HomeController(MovieContext movieContext)
    {
        _context = movieContext;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult getToKnow()
    {
        return View();
    } 
    
    [HttpGet]
    public IActionResult form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult form(Application response)
    {
        _context.Applications.Add(response);
        _context.SaveChanges();
        return View("confirmation", response);
    }
    
    
    public IActionResult home()
    {
        return View();
    }
}