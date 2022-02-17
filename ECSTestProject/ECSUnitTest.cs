using ECS.Legacy;
using NUnit.Framework;

namespace ECSTestProject
{
    public class ECSUnitTest
    {
        private ECSClass uut;
        private int testThreshold;
        [SetUp]
        public void Setup()
        {
            uut = new ECSClass(testThreshold);
            ITempSensor testTempSensor = new FakeTempSensor();
            uut._tempSensor = testTempSensor;
        }

        [Test]
        public void GetCurTempNoSeed()
        {
            int result;
            result=uut.GetCurTemp();
            Assert.That(result, Is.EqualTo(1));
        }
    }
}