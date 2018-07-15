using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Runtime.InteropServices;
>>>>>>> wallington
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
<<<<<<< HEAD
=======
        
>>>>>>> wallington

        public int addingNumber()
        {
            addAnswer = addNumberone + addNumbertwo;
            Console.WriteLine("The sum of these two numbers is {0}", + addAnswer);
            return addAnswer;

        }

        public void SmartAdd(int argumentOne, int argumentTwo)
        {
<<<<<<< HEAD
            addNumberone = argumentOne;
            addNumbertwo = argumentTwo;
            addAnswer = (argumentOne + addNumbertwo) * 2; 
            
=======
            argumentOne = addNumberone;
            argumentTwo = addNumbertwo;
            addAnswer = argumentOne + argumentTwo; 
>>>>>>> wallington
            Console.WriteLine("The sum of these two numbers is {0} is doube", +addAnswer);
        }

    }
}
