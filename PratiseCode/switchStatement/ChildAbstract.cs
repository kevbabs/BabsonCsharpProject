using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public  abstract class ChildAbstract : AbstractClass
    {
        public override void AddMe(int numOne, int numTwo)
        {
            addResult = numOne + numTwo;
        }

        public override void AddMe(double numOne, double numTwo)
        {
            addResult = numOne + numTwo;
        }
    }
}
