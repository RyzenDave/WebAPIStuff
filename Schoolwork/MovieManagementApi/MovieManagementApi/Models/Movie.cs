using MovieManagementApi.Models.Enums;
using System.Reflection;

namespace MovieManagementApi.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public Genre Genre { get; set; }
    }
}
