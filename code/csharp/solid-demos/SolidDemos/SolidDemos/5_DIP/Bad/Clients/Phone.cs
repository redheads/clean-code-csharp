using System;

namespace SolidDemos._5_DIP.Bad.Clients
{
    public class Phone
    {
        public void CreateSMSMessage(string weatherCondition)
        {
            Console.WriteLine($"It is {weatherCondition}!");
        }
    }
}