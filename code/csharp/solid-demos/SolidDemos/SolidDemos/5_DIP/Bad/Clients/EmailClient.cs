using System;

namespace SolidDemos._5_DIP.Bad.Clients
{
    public class EmailClient
    {
        public void CreateEmailMessage(string weatherCondition)
        {
            Console.WriteLine($"It is {weatherCondition}!");
        }
    }
}