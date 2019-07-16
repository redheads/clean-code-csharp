using FluentAssertions;
using SolidDemos._5_DIP.Good.Clients;
using Xunit;

namespace SolidDemos._5_DIP.Good
{
    public class WeatherTrackerTests
    {
        private readonly INotifier[] _notifiers = {new EmailClient(), new MobileDevice()};

        [Theory]
        [InlineData("sunny", "It is sunny!")]
        [InlineData("rainy", "It is raining!")]
        public void Notification_is_called(string input, string expected)
        {
            // Arrange
            var sut = new WeatherTracker(_notifiers);

            // Act
            var result = sut.SetWeatherCondition(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}