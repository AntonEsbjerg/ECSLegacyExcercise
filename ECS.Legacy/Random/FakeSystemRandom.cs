using System;

namespace ECS.Legacy
{
    public class FakeSystemRandom: ISystemRandom
    {
        private static int _customRandom;
        private static Random _random;
        public int Get()
        {
            return 1;
        }

        public int Get(int seed)
        {
            return seed;
        }
    }
}