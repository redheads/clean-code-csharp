namespace SolidDemos._4_ISP.Bad
{
    public interface IVehicle
    {
        string StartEngine();
        string Drive();
    }

    public class Car : IVehicle
    {
        public string StartEngine() => "Brum, Brum";

        public string Drive() => "moving forward fast";
    }

    public class Bicycle : IVehicle
    {
        public string StartEngine()
        {
            throw new System.NotImplementedException();
        }

        public string Drive() => "moving forward slowly";
    }
}