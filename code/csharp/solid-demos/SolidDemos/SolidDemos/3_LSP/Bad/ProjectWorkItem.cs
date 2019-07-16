using System;

namespace SolidDemos._3_LSP.Bad
{
    public class ProjectWorkItem : WorkItem
    {
        public ProjectWorkItem(Status status) : base(status) { }

        public new void Close()
        {
            if (Status == Status.Started)
            {
                Console.WriteLine("Can't close a started project work item");
                return;
            }
            
            base.Close();
        }
    }
}