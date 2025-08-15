namespace Class_04_exercise.DTOs
{
    public class AddNoteDto
    {
        public string Text { get; set; }
        public string Priority { get; set; } // Assuming Priority is a string representation of an enum
        public int UserId { get; set; } // Assuming User is a string identifier (e.g., email or username)
        public List<int> TagId { get; set; } = new List<int>(); // List of tag names or identifiers
    }
}
