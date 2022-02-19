using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    class FakeWriter : IWriter
    {
        public string Write()
        {
            string text = "fake writer writes.";
            Console.Write(text);
            return text;
        }

        public string Write(string seed)
        {
            string text = "fake writer writes with seed.";
            Console.Write(text);
            return text;
        }

        public bool RunSelfTest()
        {
            return true;
        }



    }
}
