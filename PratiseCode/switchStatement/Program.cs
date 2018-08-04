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
            CallConstructor callConstructor = new CallConstructor("Cat", 2, 4);
            callConstructor.CreateAnimal();
            Console.WriteLine("------------------------------");

            Console.WriteLine("------------------------------");

            CallConstructor callConstructorNew = new CallConstructor("Dragon", 2, 4, 1);
            callConstructorNew.CreateAnimal();



            Console.ReadKey();
        }
     }
}


