using System;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using Xunit;

namespace SolidDemos._5_DIP.Good
{
    public class WeatherTrackerTests
    {
        private readonly INotifier _notifier;

        public WeatherTrackerTests()
        {
            _notifier = Substitute.For<INotifier>();
        }

        [Theory]
        [InlineData("sunny", "sunny")]
        public void Notification_is_called(string input, string expected)
        {
            // Arrange
            var sut = new WeatherTracker(_notifier);

            // Act
            sut.SetWeatherCondition(input);

            // Assert
            _notifier.Received().Alert(expected);
        }
    }
}