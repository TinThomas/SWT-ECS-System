using System;
using Refactored_ECS.Heater;

namespace HeaterUnitTest
{
    public class HeaterFake : IHeater
    {
        private bool _heaterStatus = false;
        public bool TurnOn()
        {
            Console.WriteLine("HeaterFake turned on");
            return _heaterStatus = true;
        }
        public bool TurnOff()
        {
            Console.WriteLine("Heater fake turned off");
            return _heaterStatus = false;
        }

        public bool RunSelfTest()
        {
            Console.WriteLine("Heater fake running selftest");
            return true;
        }
    }
}
