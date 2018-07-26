using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork2
{
    public class Subtract
    {
        //this are variable for subtraction
        public int subNumOne;
        public int subNumTwo;
        public int subAnwser;

        //this my subtract method
        public void subtractNumber()
        {
            subAnwser = subNumOne - subNumTwo;
            Console.WriteLine("The answer to the subtraction is [0]", subAnwser);
        }
    }
}
