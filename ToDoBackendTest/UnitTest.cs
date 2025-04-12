using TodoBackend;

namespace ToDoBackendTest
{
    public class Tests
    {
        private readonly TaskList _taskItems = [];
        [SetUp]
        public void Setup()
        {
            _taskItems.Add(new TaskItem { Title = "Task 1" });
            _taskItems.Add(new TaskItem { Title = "Task 2" });
        }
        [Test]
        public void AddingTasks()
        {
            _taskItems.Add(new TaskItem { Title = "Task 3" });
            Assert.That(_taskItems, Has.Count.EqualTo(3));
        }

        [Test]
        public void GetTasksThatExists()
        {
            TaskItem result = _taskItems.GetByName("Task 2");
            Assert.That(result.Title, Is.EqualTo("Task 2"));
        }

        [Test]
        public void GetTasksThatDoesntExists()
        {
            var ex = Assert.Throws<KeyNotFoundException>(() => _taskItems.GetByName("Task 4"));
            Assert.That(ex.Message, Is.EqualTo("Task with title 'Task 4' not found."));
        }
    }
}