namespace SolidDemos._2_OCP.Bad
{
    public class Greeter
    {
        private string _formality;
        
        public void SetFormality(string formality)
        {
            _formality = formality;
        }

        public string Greet()
        {
            switch (_formality)
            {
                case "formal":
                    return "Good evening, sir";
                case "casual":
                    return "Sup bro?";
                case "intimate":
                    return "Hello Darling";
                default:
                    return "Hello";
            }
        }
    }
}