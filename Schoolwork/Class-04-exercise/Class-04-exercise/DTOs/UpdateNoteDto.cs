using Class_04_exercise.Models.Enums;

namespace Class_04_exercise.DTOs
{
    public class UpdateNoteDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public PriorityEnum Priority { get; set; }
        public int UserId { get; set; }
        public List<int> TagIds { get; set; }
    }
}
