using System;
using Refactored_ECS.Heater;

namespace HeaterUnitTest
{
    public class HeaterFake : IHeater
    {
        public bool HeaterStatus;
        public void TurnOn()
        {
            Console.WriteLine("HeaterFake turned on");
            HeaterStatus = true;
        }
        public void TurnOff()
        {
            Console.WriteLine("Heater fake turned off");
            HeaterStatus = false;
        }

        public bool RunSelfTest()
        {
            Console.WriteLine("Heater fake running selftest");
            return true;
        }
    }
}
