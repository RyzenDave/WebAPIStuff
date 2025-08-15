using Class_04_exercise.Models.Enums;

namespace Class_04_exercise.DTOs
{
    public class NoteDto
    {
        public string Text { get; set; }
        public PriorityEnum Priority { get; set; }
        public string User { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}
