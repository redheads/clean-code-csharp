namespace SolidDemos._4_ISP.Good
{
    public interface IWithEngine
    {
        string StartEngine();
    }

    public interface IVehicle
    {
        string Drive();
    }

    public class Car : IVehicle, IWithEngine
    {
        public string Drive() => "Moving forward fast";

        public string StartEngine() => "Brum, Brum";
    }
    
    public class Bicycle : IVehicle
    {
        public string Drive() => "moving forward slowly";
    }
    
    public interface IVehicleWithEngine : IVehicle, IWithEngine { }

    public class Bus : IVehicleWithEngine
    {
        public string Drive() => "Moving with passengers";

        public string StartEngine() => "BRUM, BRUM, BRUM";
    }
}