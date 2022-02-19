using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    public class ConsoleWriter : IWriter
    {
        public string Write()
        {
            string text = "I don't know why i made this method.";
            Console.Write(text);
            return text;
        }

        public string Write(string seed)
        {
            string text = seed;
            Console.Write(text);
            return text;
        }

        public bool RunSelfTest()
        {
            return true;
        }






    }
}
