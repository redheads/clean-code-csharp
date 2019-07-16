namespace SolidDemos._2_OCP.Good
{
    public class Greeter
    {
        private readonly IPersonality _personality;

        public Greeter(IPersonality personality)
        {
            _personality = personality;
        }

        public string Greet()
        {
            return _personality.Greet();
        }
    }
}