using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevBabs
{
    class Program
    {
        //This is a single line comment and this a main method
        /*
         * This is a multiple line comment
         * This is a multiple line comment
         */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello class of 2018");
            //datatype variable value
            int age = 30;
            char alphabet = 'K';
            string name ="Kevin"; // will take alphernumeric value e.g. kevin25
            double bankBalance = 2500;
            bool stateValue = true;
            
            Console.WriteLine("My age is " + age);
            Console.WriteLine("The first letter is " + alphabet);
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My current bank balanace is " + bankBalance);
            Console.WriteLine("I am man " + stateValue);
            Console.WriteLine(DateTime.Now);

            // This if statement
            if (name == "Kevin")
            {
                Console.WriteLine("This is my name");  
            }
            Console.ReadKey();
        }
    }
}
