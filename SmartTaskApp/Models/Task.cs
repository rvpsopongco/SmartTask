using System;

namespace SmartTaskApp.Models
{
    public enum Category
    {
        School,
        Work,
        Personal
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, Category category)
        {
            Title = title;
            Category = category;
            IsCompleted = false;
        }
    }
}