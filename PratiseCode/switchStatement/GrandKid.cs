using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public class GrandKid : ChildAbstract
    {
        public override void AddMe(int numOne, double numTwo)
        {
            addResult = numOne + numTwo;
        }
    }
}
