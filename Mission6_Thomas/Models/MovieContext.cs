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
    // DbSet representing the "Movies" table in the database. This will hold the application data.
    public DbSet<Movie> Movies { get; set; }
    // Entity Framework DbSet to represent the categories table in the database
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data
    {
        modelBuilder.Entity<Category>().HasData(
            // List to store predefined category data
            new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
            new Category { CategoryId = 2, CategoryName = "Drama" },
            new Category { CategoryId = 3, CategoryName = "Television" },
            new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
            new Category { CategoryId = 5, CategoryName = "Comedy" },
            new Category { CategoryId = 6, CategoryName = "Family" },
            new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
            new Category { CategoryId = 8, CategoryName = "VHS" }
            
        );
    }
}