using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SmartTaskApp.Models;

namespace SmartTaskApp.Storage
{
    public class JsonStorage : IStorage
    {
        private string filePath = "tasks.json";

        public void Save(List<TaskItem> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(filePath, json);
        }

        public List<TaskItem> Load()
        {
            if (!File.Exists(filePath))
                return new List<TaskItem>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json);
        }
    }
}