using NUnit.Framework;
using ECS.Legacy;


namespace ECSTestProject
{
    public class Tests
    {
        private ITempSensor uut;
        private ISystemRandom testRandom;
        [SetUp]
        public void Setup()
        {
            testRandom = new FakeSystemRandom();
            uut = new TempSensor(testRandom);
        }

        [TestCase(-1,-1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1000000, 1000000)]
        public void GetTempWithSeed_OutputEqualInput(int Ip, int Op)
        {
            int result;
            result = uut.GetTemp(Ip);
            Assert.That(result,Is.EqualTo(Op));
        }
        [Test]
        public void GetTempNoSeed_OutputEqualInput()
        {
            int result;
            result = uut.GetTemp();
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void RunSelfTest_returnTrue()
        {
            bool result;
            result = uut.RunSelfTest();
            Assert.That(result, Is.True);
        }
    }
}