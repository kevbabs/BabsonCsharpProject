using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //private static object enterName;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and press the Enter key");
            ////provide your enterName prompt
            String enterName = Console.ReadLine();

            ////validate name entered
            ////bool stateValue = true;
            if (enterName.Equals("Kevin") || (enterName.Equals("Babs")))
            {

                Console.WriteLine(enterName + " You are welcome to the programming course");
                //provide your courseName prompt
                Console.WriteLine("Enter course name");
                string courseName = Console.ReadLine();
                Console.WriteLine();
                //int coursePayment = Convert.ToInt32((Console.ReadLine()));

                // Console.WriteLine(enterName = "John" + "you have paid " + coursePayment);
                Console.WriteLine("You are enroll for " + courseName);


            }
            else
            {
                Console.WriteLine(enterName + " Sorry, you are not registered for this course");
            }

            Console.ReadKey();
        }
    }
}
