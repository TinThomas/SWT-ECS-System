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
        private IHeater _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new HeaterFake();
        }

        [Test]
        public void TurnOn_Void_Void()
        {
            _uut.TurnOn();
        }

        [Test]
        public void TurnOff_Void_Void()
        {
            _uut.TurnOff();
        }

        [Test]
        public void RunSelfTest_Void_True()
        {
            var result = _uut.RunSelfTest();
            Assert.AreEqual(true, result);
        }
    }
}
