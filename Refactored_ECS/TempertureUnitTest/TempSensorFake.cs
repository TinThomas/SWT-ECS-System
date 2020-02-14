using System;
using Refactored_ECS.TempSensor;

namespace TempertureUnitTest
{
    public class TempSensorFake : ITempSensor
    {
        public int GetTemp()
        {
            //Always returns 22 for testing purposes
            return 22;
        }

        public bool RunSelfTest_True()
        {
            Console.WriteLine("TempSensorFake running selftest");
            return true;
        }
    }
}
