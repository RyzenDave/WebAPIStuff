namespace Class_04_exercise.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>(); 
                  
    }
}
