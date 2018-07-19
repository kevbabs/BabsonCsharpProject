using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SamB
{
    public class Division
    {
        public int divNumberOne;
        public int divNumberTwo;
        public int divAnswer;

        public int DivisionNum(int parameterOne, int parameterTwo)
        {
            divNumberOne = parameterOne;
            divNumberTwo = parameterTwo;
            divAnswer = parameterTwo/parameterOne;
            Console.WriteLine("The result of the division is {0}", divAnswer);
            return divAnswer;
        }

    }
}
