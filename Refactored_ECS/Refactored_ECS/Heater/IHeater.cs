using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored_ECS.Heater
{
    public interface IHeater
    {
        bool TurnOn();
        bool TurnOff();
        bool RunSelfTest();
    }
}
