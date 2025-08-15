using Class_04_exercise.Models;

namespace Class_04_exercise
{
    public class StaticDb
    {
        public static List<User> Users { get; } = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Smith",
                Email = "alice.smith@example.com",
                Password = "Password123!",
                Notes = new List<Note>()
            },
            new User
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Johnson",
                Email = "bob.johnson@example.com",
                Password = "SecurePass456!",
                Notes = new List<Note>()
            },
            new User
            {
                Id = 3,
                FirstName = "Charlie",
                LastName = "Williams",
                Email = "charlie.williams@example.com",
                Password = "MyPass789!",
                Notes = new List<Note>()
            },
            new User
            {
                Id = 4,
                FirstName = "Diana",
                LastName = "Brown",
                Email = "diana.brown@example.com",
                Password = "DianaPass321!",
                Notes = new List<Note>()
            },
            new User
            {
                Id = 5,
                FirstName = "Ethan",
                LastName = "Davis",
                Email = "ethan.davis@example.com",
                Password = "EthanPwd654!",
                Notes = new List<Note>()
            }
        };
        public static List<Tag> Tags { get; } = new List<Tag>
        {
            new Tag { Id = 1, Name = "Work", Color = "Blue" },
            new Tag { Id = 2, Name = "Personal", Color = "Green" },
            new Tag { Id = 3, Name = "Urgent", Color = "Red" },
            new Tag { Id = 4, Name = "Home", Color = "Orange" },
            new Tag { Id = 5, Name = "Study", Color = "Purple" }
        };
        public static List<Note> Notes { get; } = new List<Note>
        {
            new Note
            {
                Id = 1,
                Text = "Complete project report",
                Priority = Models.Enums.PriorityEnum.High,
                UserId = 1,
                Tags = [ new Tag { Id = 1, Name = "Work", Color = "Blue" }, new Tag { Id = 3, Name = "Urgent", Color = "Red" } ]
            },
            new Note
            {
                Id = 2,
                Text = "Grocery shopping",
                Priority = Models.Enums.PriorityEnum.Medium,
                UserId = 2,
                Tags = [ new Tag { Id = 4, Name = "Home", Color = "Orange" } ]
            },
            new Note
            {
                Id = 3,
                Text = "Prepare for exam",
                Priority = Models.Enums.PriorityEnum.Low,
                UserId = 3,
                Tags = [ new Tag { Id = 5, Name = "Study", Color = "Purple" } ]
            },
            new Note
            {
                Id = 4,
                Text = "Call mom",
                Priority = Models.Enums.PriorityEnum.Medium,
                UserId = 4,
                Tags = [ new Tag { Id = 2, Name = "Personal", Color = "Green" } ]
            },
            new Note
            {
                Id = 5,
                Text = "Plan vacation",
                Priority = Models.Enums.PriorityEnum.Low,
                UserId = 5,
                Tags = [ new Tag { Id = 1, Name = "Work", Color = "Blue" }, new Tag { Id = 5, Name = "Study", Color = "Purple" } ]
            }
        };
    }
}
