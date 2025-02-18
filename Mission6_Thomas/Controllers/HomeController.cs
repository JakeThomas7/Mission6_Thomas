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
        // If the form submission is valid (if there are no errors from the form submission based on the database restrictions)
        if (ModelState.IsValid)
        {
            // Add the response to the database
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("confirmation", response);
        }
        else
        {
            // If it's not valid reload the page and we will need to sent the view bag again.
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
    
    // The get request for our edit page. This information will load up once you open the edit page.
    [HttpGet]
    public IActionResult Edit(int id)
    {
        // Get the record from the database that we want to edit
        Movie recordToEdit = _context.Movies.Single(x => x.MovieId == id);
        // Get the list of Categories to populate in the dropdown
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        
        return View("form", recordToEdit);
    }
    // Post request for our edit page. This will trigger when a user submits on the form page from an edit.
    [HttpPost]
    public IActionResult Edit(Movie response)
    {
        // Update the record that is sent in from the form
        _context.Update(response);
        _context.SaveChanges();
        // Send the user back to the movie list to view the changes.
        return RedirectToAction("movieList");
    }
    
    // Get request for our Delete page. This will run when a user clicks the delete button on the movie list page.
    [HttpGet]
    public IActionResult Delete(int id)
    {  
        // Get the record from the databse based on the ID of the row.
        Movie recordToDelete = _context.Movies.Single(x => x.MovieId == id);
        return View(recordToDelete);
    }
    // Post request for the delete. This will run when the user confirms that they want to delete something.
    [HttpPost]
    public IActionResult Delete(Movie response)
    {
        // Remove the record that is passed through
        _context.Movies.Remove(response);
        _context.SaveChanges();
        // Bring them back to the movie list page.
        return RedirectToAction("movieList");
    }
    
}