using MovieManagementApi.Models.Enums;

namespace MovieManagementApi.DTO
{
    public class UpdateMovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
    }
}
