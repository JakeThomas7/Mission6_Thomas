using Microsoft.EntityFrameworkCore;

namespace Mission6_Thomas.Models;

// This is the MovieContext class, responsible for setting up and interacting with the database.
public class MovieContext : DbContext
{
    // Constructor that takes DbContextOptions to pass into the base class for configuring the context
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
        // The base constructor initializes the DbContext with the provided options.

    }
    // DbSet representing the "Applications" table in the database. This will hold the application data.
    public DbSet<Movie> Movies { get; set; }
}