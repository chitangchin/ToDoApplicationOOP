namespace TodoBackend
{
    public class TaskList : HashSet<TaskItem>
    {
        public new bool Add(TaskItem task)
        {
            return base.Add(task);
        }
    }
}
