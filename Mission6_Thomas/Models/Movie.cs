using System.ComponentModel.DataAnnotations;

namespace Mission6_Thomas.Models
{
    public class Movie
    {
        // Movie information class which contains all values needed for a movie submission and the get / set methods
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string movieName { get; set; }
        public string movieCategory { get; set; }
        public int movieYear { get; set; }
        public string movieDirector { get; set; }
        public string movieRating { get; set; }
        public string? notes { get; set; }
        public string? lentTo { get; set; }
        public bool? edited { get; set; } = false;

    }
}

