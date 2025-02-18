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
        // Title is required and will send this message if it is not entered in.
        [Required(ErrorMessage = "The Movie Title is Required")]
        public string Title { get; set; }
        // Year is required and will send this message if not entered in correctly.
        // It also needs to be between 1888 and 9999
        [Required(ErrorMessage = "The Movie Year is Required")]
        [Range(1888,9999, ErrorMessage = "The Movie Year must be between 1888 and 9999")]
        public int Year { get; set; }
        // Edited is required but will fill with false always.
        [Required]
        public bool Edited { get; set; } = false;
        // CopiedToPlex is required but will fill with flase always.
        [Required]
        public bool CopiedToPlex { get; set; } = false;
        // Set up the foreign key relationship for Category
        [ForeignKey("categoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? Notes { get; set; }
        public string? LentTo { get; set; }

    }
}

