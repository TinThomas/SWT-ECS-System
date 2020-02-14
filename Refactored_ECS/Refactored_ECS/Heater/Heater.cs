namespace Refactored_ECS.Heater
{
    public class Heater : IHeater
    {
        private bool _heaterStatus = false;
        public bool TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            return _heaterStatus = false;
        }

        public bool TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            return _heaterStatus = true;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}