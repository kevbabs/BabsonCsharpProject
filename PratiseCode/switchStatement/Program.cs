using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Borough name");
            string boroughName = Console.ReadLine();

            //switch statement
            switch (boroughName)
            {
                case "sutton":
                    Console.WriteLine(" I live in {0}", boroughName);
                    break;
                case "newham":
                    Console.WriteLine("I live in {0}" + boroughName);
                    break;
                default:
                    Console.WriteLine("Sorry the borough is not know, {0}, is not listed", boroughName);
                    break;

              
            }

            Console.ReadKey();

        }
    }
}
