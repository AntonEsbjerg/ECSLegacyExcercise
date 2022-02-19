using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    class ConsoleWriter : IWriter
    {
        public void Write()
        {
            Console.Write("I don't know why i made this method.");
        }

        public void Write(string seed)
        {
            Console.Write(seed);
        }

        public bool RunSelfTest()
        {
            return true;
        }






    }
}
