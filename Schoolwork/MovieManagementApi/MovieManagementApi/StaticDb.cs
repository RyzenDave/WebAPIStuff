using MovieManagementApi.Models;
using MovieManagementApi.Models.Enums;

namespace MovieManagementApi
{
    public static class StaticDb
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years...",
                Year = new DateTime(1994, 1, 1),
                Genre = Genre.Drama
            },
            new Movie
            {
                Id = 2,
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc...",
                Year = new DateTime(2008, 1, 1),
                Genre = Genre.Action
            },
            new Movie
            {
                Id = 3,
                Title = "Inception",
                Description = "A thief who steals corporate secrets...",
                Year = new DateTime(2010, 1, 1),
                Genre = Genre.SciFi
            },
            new Movie
            {
                Id = 4,
                Title = "The Hangover",
                Description = "Three buddies wake up from a bachelor party...",
                Year = new DateTime(2009, 1, 1),
                Genre = Genre.Comedy
            },
            new Movie
            {
                Id = 5,
                Title = "The Conjuring",
                Description = "Paranormal investigators help a family terrorized...",
                Year = new DateTime(2013, 1, 1),
                Genre = Genre.Horror
            }
        };
    }
}
