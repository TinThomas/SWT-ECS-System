using System;
using Refactored_ECS.Heater;

namespace HeaterUnitTest
{
    public class HeaterFake : IHeater
    {
        public void TurnOn()
        {
            Console.WriteLine("HeaterFake turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Heater fake turned off");
        }

        public bool RunSelfTest()
        {
            Console.WriteLine("Heater fake running selftest");
            return true;
        }
    }
}
