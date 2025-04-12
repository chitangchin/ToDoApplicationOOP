using TodoBackend;

namespace ToDoBackendTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            TaskList taskItems = [];
            taskItems.Add(new TaskItem { Title = "Task 1" });
            taskItems.Add(new TaskItem { Title = "Task 2" });
            Assert.That(taskItems, Has.Count.EqualTo(2));
        }
    }
}