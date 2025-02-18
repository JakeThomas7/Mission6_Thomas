using System.ComponentModel.DataAnnotations;

namespace Mission6_Thomas.Models;

public class Category
{
    // Category Database
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    
}