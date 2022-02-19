using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    class FakeWriter : IWriter
    {
        public string Write()
        {
            return "fake";
        }

        public string Write(string seed)
        {
            return seed;
        }

        public bool RunSelfTest()
        {
            return true;
        }



    }
}
