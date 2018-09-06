using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Babs_Automation
{
    [TestClass]

    public class SoloClass
    {
        [TestMethod]
        public void SoloMethodFromAnotherClass()
        {
            Console.WriteLine("I am from Solo class");
        }
    }
}
