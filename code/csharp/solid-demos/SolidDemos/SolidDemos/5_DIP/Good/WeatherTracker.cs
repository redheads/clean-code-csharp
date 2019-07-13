namespace SolidDemos._5_DIP.Good
{
    public class WeatherTracker
    {
        private readonly INotifier _notifier;
        
        public WeatherTracker(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void SetWeatherCondition(string weatherCondition)
        {
            _notifier.Alert(weatherCondition);
        }
    }
}