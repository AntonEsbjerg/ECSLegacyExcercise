using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    public interface IWriter
    {
        public string Write();

        public string Write(string seed);

        public bool RunSelfTest(); 

    }
}
