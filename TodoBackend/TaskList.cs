namespace TodoBackend
{
    public class TaskList : HashSet<TaskItem>
    {
        public new bool Add(TaskItem task)
        {
            return base.Add(task);
        }
        public TaskItem GetByName(string title)
        {
            var taskItem = this.FirstOrDefault(task => task.Title == title);
            return taskItem ?? throw new KeyNotFoundException($"Task with title '{title}' not found.");
        }
    }
}
