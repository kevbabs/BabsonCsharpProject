using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinaPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter borough name");
            string boroughName = Console.ReadLine();
            
            //switch statement
            switch (boroughName)
            {
                case "Sutton":
                    Console.WriteLine(" I live in london borough of Sutton {0}", boroughName);    
            }
        }
    }
}
