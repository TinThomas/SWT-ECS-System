using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Refactored_ECS.Heater;

namespace HeaterUnitTest
{
    [TestFixture]
    public class HeaterUnitTest
    {
        private IHeater uut;

        [SetUp]
        public void SetUp()
        {
            uut = new HeaterFake();
        }

        [Test]
        public void test()
        {

        }
    }
}
