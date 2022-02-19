using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    class FakeWriter : IWriter
    {
        public void Write()
        {
            Console.Write("fake writer writes.");
        }

        public void Write(string seed)
        {
            Console.Write("fake writer writes with seed.");
        }

        public bool RunSelfTest()
        {
            return true;
        }



    }
}
