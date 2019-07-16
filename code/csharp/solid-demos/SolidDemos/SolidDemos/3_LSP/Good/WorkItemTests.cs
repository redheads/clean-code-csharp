using FluentAssertions;
using Xunit;

namespace SolidDemos._3_LSP.Good
{
    public class WorkItemTests
    {
        [Fact]
        public void Closing_an_open_workItem_changes_to_status_closed()
        {
            var sut = new WorkItem(Status.Open);
            sut.Close();
            sut.Status.Should().Be(Status.Closed);
        }

        [Fact]
        public void Closing_a_started_workItem_changes_status_to_closed()
        {
            var sut = new WorkItem(Status.Started);
            sut.Close();
            sut.Status.Should().Be(Status.Closed);
        }

        [Fact]
        public void Closing_a_started_project_workItem_changes_status_to_closed()
        {
            var sut = new ProjectWorkItem(Status.Started);
            sut.Close();
            sut.Status.Should().Be(Status.Closed);
        }

        [Fact]
        public void Closing_an_open_project_workItem_doesnt_change_status()
        {
            var sut = new ProjectWorkItem(Status.Open);
            sut.Close();
            sut.Status.Should().Be(Status.Open);
        }
    }
}