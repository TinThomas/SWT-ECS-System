using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Refactored_ECS.TempSensor;

namespace TempertureUnitTest
{
    [TestFixture]
    public class TempertureUnitTest
    {
        private TempSensorFake uut;

        [SetUp]
        public void SetUp()
        {
            uut = new TempSensorFake();
        }

        [Test]
        public void test_GetTemp()
        {
            var result = uut.GetTemp();
            Assert.AreEqual(22, result);
        }

        [Test]
        public void test_Runself()
        {
            var result = uut.RunSelfTest();
            Assert.AreEqual(true, result);
        }
    }
}
