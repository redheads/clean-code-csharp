using FluentAssertions;
using Xunit;

namespace SolidDemos._3_LSP.Bad
{
    public class WorkItemTests
    {
        [Fact]
        public void Closing_a_workItem_changes_status_to_closed()
        {
            var sut = new WorkItem(Status.Started);
            sut.Close();
            sut.Status.Should().Be(Status.Closed);
        }

        [Fact(Skip = "This test fails!")]
        public void Closing_a_project_workItem_changes_status_to_closed()
        {
            var sut = new ProjectWorkItem(Status.Started);
            sut.Close();
            sut.Status.Should().Be(Status.Closed); // <- Fails!!
        }
    }
}