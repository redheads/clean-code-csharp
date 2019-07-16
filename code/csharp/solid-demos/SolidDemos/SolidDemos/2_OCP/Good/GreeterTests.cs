using FluentAssertions;
using Xunit;

namespace SolidDemos._2_OCP.Good
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
            var sut = new Greeter(PersonalityFactory(input));
            sut.Greet().Should().Be(expected);
        }

        private static IPersonality PersonalityFactory(string input)
        {
            switch (input)
            {
                case "formal":
                    return new FormalPersonality();
                case "casual":
                    return new CasualPersonality();
                case "intimate":
                    return new IntimatePersonality();
                default:
                    return new DefaultPersonality();
            }
        }
    }
}