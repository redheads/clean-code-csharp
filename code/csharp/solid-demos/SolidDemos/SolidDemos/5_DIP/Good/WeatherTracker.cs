namespace SolidDemos._5_DIP.Good
{
    public class WeatherTracker
    {
        private readonly INotifier[] _notifiers;
        
        public WeatherTracker(params INotifier[] notifiers)
        {
            _notifiers = notifiers;
        }

        public string SetWeatherCondition(string weatherCondition)
        {
            foreach (var notifier in _notifiers)
            {
                var result = notifier.Alert(weatherCondition);
                
                if (!string.IsNullOrWhiteSpace(result))
                {
                    return result;
                }
            }

            return string.Empty;
        }
    }
}