namespace SolidDemos._5_DIP.Good.Clients
{
    public class MobileDevice : INotifier
    {
        public string Alert(string weatherCondition)
        {
            if (weatherCondition == "rainy")
            {
                return "It is raining!";
            }

            return string.Empty;
        }
    }
}