using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored_ECS.Heater
{
    class HeaterFake : IHeater
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
