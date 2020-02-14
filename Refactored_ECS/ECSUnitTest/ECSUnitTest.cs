using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaterUnitTest;
using NUnit.Framework;
using Refactored_ECS;
using TempertureUnitTest;

namespace ECSUnitTest
{
    [TestFixture]
    public class ECSUnitTest
    {
        private ECS uut;
        private HeaterFake heater;
        private TempSensorFake sensor;

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

        #region Regulate

        [Test]
        public void Regulate_Threshold30_True()
        {
            uut.SetThreshold(30);
            uut.Regulate();
            Assert.That(heater.HeaterStatus, Is.True);
        }

        [Test]
        public void Regulate_Threshold20_False()
        {
            uut.SetThreshold(20);
            uut.Regulate();
            Assert.That(heater.HeaterStatus, Is.False);
        }
        [Test]
        public void Regulate_ThresholdNegative10_False()
        {
            uut.SetThreshold(-20);
            uut.Regulate();
            Assert.That(heater.HeaterStatus, Is.False);
        }
        [Test]
        public void Regulate_Threshold22_False()
        {
            uut.SetThreshold(22);
            uut.Regulate();
            Assert.That(heater.HeaterStatus, Is.False);
        }
        #endregion

        [Test]
        public void GetCurrentTemperature_22()
        {
            int res = uut.GetCurTemp();
            Assert.That(res, Is.EqualTo(22));
        }

        [Test]
        public void RunSelfTest_True()
        {
            bool res = uut.RunSelfTest();
            Assert.That(res, Is.True);
        }
    }
}
