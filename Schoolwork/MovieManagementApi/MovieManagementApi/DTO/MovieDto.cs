using MovieManagementApi.Models.Enums;

namespace MovieManagementApi.DTO
{
    public class MovieDto
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; } 
        public DateTime Year { get; set; }
    }
}
