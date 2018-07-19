using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamB
{
    public class Subtract
    {
        //this are variable for subtraction
        public int subNumberone;
        public int subNumbertwo;
        public int subAnwser;

        //this my subtract method
        public void subtractNumber()
        {
            subAnwser = subNumberone - subNumbertwo;
            Console.WriteLine("The answer to the subtraction is {0}", subAnwser);
  
        }


    }
}
