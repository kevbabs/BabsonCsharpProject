using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork2
{
    public class Program
    {
        static void Main(string[] args)//this the main method
        {
            Subtract subtractPositive new Subtract();
            subtractPositive.subNumOne = 10;
            subtractPositive.subNumTwo = 6;
            subtractPositive.subtractNumber();

            Console.ReadKey();
        }
    }
}
