using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public enum Genres
    {
        Action, Horror, Drama, Thriller, Adventure, Comedy
    }

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; } = Genres.Action;

        [Range(1, 30), Required]
        public decimal Price { get; set; }
    }
}