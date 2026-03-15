using System.Collections.Generic;
using SmartTaskApp.Models;

namespace SmartTaskApp.Storage
{
    public interface IStorage
    {
        void Save(List<TaskItem> tasks);
        List<TaskItem> Load();
    }
}