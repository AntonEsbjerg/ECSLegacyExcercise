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




        [TestCase()]
        [TestCase()]
        [TestCase()]
        [Test]
        public void testone()
        {

        }


        [Test]
        public void testtwo()
        {

        }

        [Test]
        public void testtree()
        {

        }








    }
}
