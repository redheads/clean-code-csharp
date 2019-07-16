using System;

namespace SolidDemos._3_LSP.Good
{
    public class ProjectWorkItem : WorkItem
    {
        public override bool CanClose() => Status == Status.Started;

        public ProjectWorkItem(Status status) : base(status) { }
    }
}