namespace SolidDemos._3_LSP.Good
{
    public class WorkItem
    {
        public WorkItem(Status status)
        {
            Status = status;
        }

        public Status Status { get; private set; }

        public virtual bool CanClose() => true;
        
        public void Close()
        {
            if (CanClose())
            {
                Status = Status.Closed;    
            }
        }
    }
}