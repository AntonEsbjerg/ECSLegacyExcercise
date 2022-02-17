using System;

namespace ECS.Legacy
{
    internal class TempSensor:ITempSensor
    {
        private ISystemRandom gen = new SystemRandom();

        public int GetTemp()
        {
            return gen.Get();
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}