using FluentAssertions;
using Xunit;

namespace SolidDemos._2_OCP.Bad
{
    public class GreeterTests
    {
        [Theory]
        [InlineData("formal", "Good evening, sir")]
        [InlineData("casual", "Sup bro?")]
        [InlineData("intimate", "Hello Darling")]
        [InlineData("", "Hello")]
        public void Greeter_returns_correct_result(string input, string expected)
        {
            var sut = new Greeter();
            sut.SetFormality(input);
            sut.Greet().Should().Be(expected);
        }
    }
}