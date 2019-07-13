using System;

namespace SolidDemos._5_DIP.Good.Clients
{
    public class MobileDevice : INotifier
    {
        public void Alert(string weatherCondition)
        {
            if (weatherCondition == "rainy")
            {
                Console.WriteLine("It is raining!");
            }
        }
    }
}