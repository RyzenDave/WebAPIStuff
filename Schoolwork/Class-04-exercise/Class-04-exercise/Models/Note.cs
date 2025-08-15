using Class_04_exercise.Models.Enums;

namespace Class_04_exercise.Models
{
    public class Note : BaseEntity
    {
        public string Text { get; set; }
        public PriorityEnum Priority { get; set; }
        public User User { get; set; } 
        public int UserId { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
