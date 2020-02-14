using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored_ECS.TempSensor
{
    class TempSensorFake : ITempSensor
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
