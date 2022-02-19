using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Writer
{
    public interface IWriter
    {
        public void Write();

        public void Write(string seed);

        public bool RunSelfTest(); 

    }
}
