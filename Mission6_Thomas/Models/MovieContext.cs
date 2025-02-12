using Microsoft.EntityFrameworkCore;

namespace Mission6_Thomas.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
        
    }
    
    public DbSet<Application> Applications { get; set; }
}