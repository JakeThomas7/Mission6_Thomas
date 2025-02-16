using Microsoft.EntityFrameworkCore;

namespace Mission6_Thomas.Models;

// This is the Movie Context document for setting up the database
public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
        
    }
    
    public DbSet<Application> Applications { get; set; }
}