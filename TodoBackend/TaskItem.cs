namespace TodoBackend
{
    public class TaskItem
    {
        public required string Title { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Title} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
