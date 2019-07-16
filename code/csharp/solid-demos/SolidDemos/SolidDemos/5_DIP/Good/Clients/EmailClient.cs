namespace SolidDemos._5_DIP.Good.Clients
{
    public class EmailClient : INotifier
    {
        public string Alert(string weatherCondition)
        {
            if (weatherCondition == "sunny")
            {
                return "It is sunny!";
            }

            return string.Empty;
        }
    }
}