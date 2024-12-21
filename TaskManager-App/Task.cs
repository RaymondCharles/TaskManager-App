using System;

namespace TaskManagerApp
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public Task(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsComplete = false;
        }

        public override string ToString()
        {
            return $"{Id}. {Title} - {Description} (Completed: {IsComplete})";
        }
    }
}
