using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaterUnitTest;
using NUnit.Framework;
using Refactored_ECS;
using Refactored_ECS.Heater;
using Refactored_ECS.TempSensor;
using TempertureUnitTest;

namespace ECSUnitTest
{
    [TestFixture]
    public class ECSUnitTest
    {
        private ECS uut;
        private IHeater heater;
        private ITempSensor sensor;

        [SetUp]
        public void SetUp()
        {
            heater = new HeaterFake();
            sensor = new TempSensorFake();
            uut = new ECS(10, sensor, heater);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(100)]
        [TestCase(-100)]
        public void SetThreshold_GetThreshold_TestCase(int a)
        {
            uut.SetThreshold(a);
            Assert.That(uut.GetThreshold(), Is.EqualTo(a));
        }

        [Test]
        public void Regulate_Threshold10_TurnOn()
        {

        }
    }
}
