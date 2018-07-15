using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SamB
{
    public class Additional
    {
        //the variable needed to perform adding number together
        public int addNumberone;
        public int addNumbertwo;
        public int addAnswer;
       

        public int addingNumber()
        {
            addAnswer = addNumberone + addNumbertwo;
            Console.WriteLine("The sum of these two numbers is {0}", + addAnswer);
            return addAnswer;

        }

        public void SmartAdd(int argumentOne, int argumentTwo)
        {
            argumentOne = addNumberone;
            argumentTwo = addNumbertwo;
            addAnswer = argumentOne + argumentTwo; 
            Console.WriteLine("The sum of these two numbers is {0} is doube", +addAnswer);
        }

    }
}
