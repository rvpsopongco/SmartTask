using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTaskApp.Services;
using SmartTaskApp.Models;

namespace SmartTaskTests
{
    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void AddTask_ShouldIncreaseCount()
        {
            var manager = TaskManager.Instance;
            manager.AddTask("Test", Category.School);

            Assert.IsTrue(manager.GetTasks().Count > 0);
        }
    }
}