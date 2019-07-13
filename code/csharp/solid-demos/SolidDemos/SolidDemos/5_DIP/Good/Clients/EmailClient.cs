using System;

namespace SolidDemos._5_DIP.Good.Clients
{
    public class EmailClient : INotifier
    {
        public void Alert(string weatherCondition)
        {
            if (weatherCondition == "sunny")
            {
                Console.WriteLine("It is sunny!");
            }
        }
    }
}