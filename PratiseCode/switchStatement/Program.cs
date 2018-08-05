using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using switchStatement.Child;
using switchStatement.FamilyTree;
using switchStatement.Parent;
using switchStatement.StaticThings;

namespace switchStatement
{
    public class Program 
    {
        static void Main(string[] args)
        {
            GrandKid childAbstract = new GrandKid();
            childAbstract.AddMe(4, 20.6);
            
            childAbstract.AdditionResult();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            
            childAbstract.AddMe(2.4, 5.6);
            childAbstract.AdditionResult();



            Console.ReadKey();

        }
     }
}


