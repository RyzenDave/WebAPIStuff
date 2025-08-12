namespace Class_03
{
    public static class StaticDb
    {
        public static List<Note> Notes = new List<Note>()
        {
            new Note
            {
                Title = "Shopping List",
                Content = "Buy milk and eggs",
                Tags = new List<Tag>
                {
                    new Tag { Name = "Groceries", Color = "Green" },
                    new Tag { Name = "Urgent", Color = "Red" }
                }
            },
            new Note
            {
                Title = "Workout Plan",
                Content = "Run 5km, 30 pushups",
                Tags = new List<Tag>
                {
                    new Tag { Name = "Fitness", Color = "Blue" },
                    new Tag { Name = "Morning", Color = "Yellow" }
                }
            },
            new Note
            {
                Title = "Project Ideas",
                Content = "Build a note app",
                Tags = new List<Tag>
                {
                    new Tag { Name = "Coding", Color = "Purple" },
                    new Tag { Name = "Ideas", Color = "Orange" }
                }
            }
        };
    }
}
