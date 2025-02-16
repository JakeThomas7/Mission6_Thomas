using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Thomas.Models;

namespace Mission6_Thomas.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;
    
    // Helping set up the database.
    public HomeController(MovieContext movieContext)
    {
        _context = movieContext;
    }
    // This will take us to index.cshtml
    public IActionResult Index()
    {
        return View();
    }
    // This will take us to get to know joel page
    public IActionResult getToKnow()
    {
        return View();
    } 
    // The get for the form will take us to the page
    [HttpGet]
    public IActionResult form()
    {
        return View();
    }
    // post for the form will submit a new movie to the database
    [HttpPost]
    public IActionResult form(Application response)
    {
        _context.Applications.Add(response);
        _context.SaveChanges();
        return View("confirmation", response);
    }
    // will take us to the home.cshtlm
    public IActionResult home()
    {
        return View();
    }
}