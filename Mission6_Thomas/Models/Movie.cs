using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Thomas.Models
{
    public class Movie
    {
        // Movie information class which contains all values needed for a movie submission and the get / set methods
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "The Movie Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The Movie Year is Required")]
        [Range(1888,9999, ErrorMessage = "The Movie Year must be between 1888 and 9999")]
        public int Year { get; set; }
        [Required]
        public bool Edited { get; set; } = false;
        [Required]
        public bool CopiedToPlex { get; set; } = false;
        
        [ForeignKey("categoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? Notes { get; set; }
        public string? LentTo { get; set; }

    }
}

