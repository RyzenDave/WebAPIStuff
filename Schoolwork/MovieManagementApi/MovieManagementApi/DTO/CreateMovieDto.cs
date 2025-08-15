using MovieManagementApi.Models.Enums;

namespace MovieManagementApi.DTO
{
    public class CreateMovieDto
    {
        public string Title { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Year { get; set; }
    }
}
