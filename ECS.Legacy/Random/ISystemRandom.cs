using System;

namespace ECS.Legacy
{
    public interface ISystemRandom
    {
        private static int _customRandom;
        private static Random _random;
        public int Get();
        public int Get(int seed);

    }
}