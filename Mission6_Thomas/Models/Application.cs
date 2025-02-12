using System.ComponentModel.DataAnnotations;

namespace Mission6_Thomas.Models
{
    public class Application
    {
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

