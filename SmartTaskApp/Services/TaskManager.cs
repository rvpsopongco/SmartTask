using System.Collections.Generic;
using SmartTaskApp.Models;

namespace SmartTaskApp.Services
{
    public class TaskManager
    {
        private static TaskManager instance;
        public static TaskManager Instance => instance ??= new TaskManager();

        private List<TaskItem> tasks = new List<TaskItem>();

        public void AddTask(string title, Category category)
        {
            tasks.Add(new TaskItem(title, category));
        }

        public void DeleteTask(int index)
        {
            if(index >=0 && index < tasks.Count)
                tasks.RemoveAt(index);
        }

        public void CompleteTask(int index)
        {
            if(index >=0 && index < tasks.Count)
                tasks[index].IsCompleted = true;
        }

        public List<TaskItem> GetTasks()
        {
            return tasks;
        }
    }
}