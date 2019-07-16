namespace SolidDemos._3_LSP.Bad
{
    public class WorkItem
    {
        public WorkItem(Status status)
        {
            Status = status;
        }

        public Status Status { get; private set; }

        public void Close()
        {
            Status = Status.Closed;
        }
    }
}