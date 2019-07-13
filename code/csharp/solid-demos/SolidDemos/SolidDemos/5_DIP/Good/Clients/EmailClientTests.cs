using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace SolidDemos._5_DIP.Good.Clients
{
    public class EmailClientTests
    {
        private readonly ITestOutputHelper _output;

        public EmailClientTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Foo()
        {
            var sut = new EmailClient();
            sut.Alert("foo");
            _output.Should().Be(new Xunit.Sdk.TestOutputHelper());
        }
    }
}