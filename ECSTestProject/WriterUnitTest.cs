using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECS.Legacy;
using ECS.Legacy.Writer;

namespace ECSTestProject
{
    class WriterUnitTest
    {
        private IWriter uut; 

        [SetUp]
        public void Setup()
        {    uut = new ConsoleWriter();   }




        [TestCase("teststring with numbers 10969023")]
        [TestCase("tEsTStrInG With CaPitaL LetTerS")]
        [TestCase("teststring with signs: !#¤%&/()=?`^*")]
        public void testone(string seed)
        {
            string WrittenString =
                uut.Write();

            Assert.Equals(WrittenString, seed);
        }

        [Test]
        public void teston()
        {
            string WrittenString = 
            uut.Write();

            Assert.Equals(WrittenString, "I don't know why i made this method.");
        }



    }
}
