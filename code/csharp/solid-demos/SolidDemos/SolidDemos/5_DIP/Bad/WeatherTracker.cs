using System;
using SolidDemos._5_DIP.Bad.Clients;

namespace SolidDemos._5_DIP.Bad
{
    public class WeatherTracker
    {
        private readonly EmailClient _emailClient;
        private readonly Phone _phone;

        public WeatherTracker()
        {
            _emailClient = new EmailClient();
            _phone = new Phone();
        }

        public void SetWeatherCondition(string weatherCondition)
        {
            if (weatherCondition == "sunny")
            {
                _emailClient.CreateEmailMessage(weatherCondition);
            } 
            else if (weatherCondition == "rainy")
            {
                _phone.CreateSMSMessage(weatherCondition);
            }
        }
    }
}