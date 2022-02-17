using System;

namespace ECS.Legacy
{
    public class TempSensor:ITempSensor
    {
        private ISystemRandom Gen;

        public TempSensor(ISystemRandom gen)
        {
            Gen = gen;
        }
        public int GetTemp()
        {
            return Gen.Get();
        }
        public int GetTemp(int seed)
        {
            return Gen.Get(seed);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}