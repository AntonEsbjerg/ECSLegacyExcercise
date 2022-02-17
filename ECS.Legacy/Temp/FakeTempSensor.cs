namespace ECS.Legacy
{
    public class FakeTempSensor:ITempSensor
    {
        public int GetTemp()
        {
            return 1;
        }

        public int GetTemp(int seed)
        {
            return seed;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}