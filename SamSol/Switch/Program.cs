using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter borough name");
            string boroughName = Console.ReadLine();

            //switch statement 

            switch (boroughName)
            {
                    Console.WriteLine(" I live in London Borough of Sutton {0}", boroughName);
            break;
            }


      
        }
    }
}
