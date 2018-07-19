using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod2018
{
    public class Division
    {
        public int divNumberOne;
        public int divNumberTwo;
        public int divAnswer;

        // divide method
        public void divNumber()
        {
            divAnswer = divNumberOne/divNumberTwo;
            Console.WriteLine("The result of the division is {0}" + divAnswer);

        }
    }
}
