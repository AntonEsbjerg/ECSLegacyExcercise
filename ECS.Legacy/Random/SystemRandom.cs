using System;
using System.Reflection.Metadata.Ecma335;

namespace ECS.Legacy
{
    public class SystemRandom: ISystemRandom
    {
        private static int _customRandom;
        private static Random _random;

        public int Get()
        {
            _random = new Random();
            _customRandom = _random.Next(-5, 45);
            return _customRandom;
        }

        public int Get(int seed)
        {
            _random = new Random(seed);
            _customRandom = _random.Next(-5, 45);
            return _customRandom;
        }
    }
}