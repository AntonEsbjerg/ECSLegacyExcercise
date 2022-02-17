using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
     public interface ITempSensor
     {
        public int GetTemp();
        public int GetTemp(int seed);
        public bool RunSelfTest();
     }
}
