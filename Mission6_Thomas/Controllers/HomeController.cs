using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        return View(new Movie());
    }
    // post for the form will submit a new movie to the database
    [HttpPost]
    public IActionResult form(Movie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("confirmation", response);
        }
        else
        {
            ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
            return View(response);
        }
    }
    // will take us to the home.cshtlm
    public IActionResult home()
    {
        return View();
    }
    // Creating the Controllers for the Movie List Page Get request
    public IActionResult movieList()
    {
        // Get all the data from our movies database, including the related Category data
        var movie = _context.Movies
            .Include(m => m.Category)  // Include the related Category data
            .OrderBy(x => x.Title)
            .ToList();
    
        // Open the movieList View with the movies including category data
        return View(movie);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        Movie recordToEdit = _context.Movies.Single(x => x.MovieId == id);
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        
        return View("form", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie response)
    {
        _context.Update(response);
        _context.SaveChanges();
        
        return RedirectToAction("movieList");
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        Movie recordToDelete = _context.Movies.Single(x => x.MovieId == id);
        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movie response)
    {
        _context.Movies.Remove(response);
        _context.SaveChanges();
        return RedirectToAction("movieList");
    }
    
}