using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using switchStatement.Child;
using switchStatement.FamilyTree;
using switchStatement.Interfacing;
using switchStatement.Parent;
using switchStatement.StaticThings;

namespace switchStatement
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.CallingAnimal("Snoopy DOGG");

            Console.WriteLine();
            dog.Animallegs(4);
            Console.WriteLine("--------------------------------------------");
            dog.CallingEle("Dumbo");
            dog.Elelegs(4);
            Console.WriteLine();
            dog.StrangeAnimal();
            Console.WriteLine();

            INterFaceClass iNterFaceClass = new Dog(); // Because the object is referencing to INterface(the inherit) it can only INterface method
            iNterFaceClass.CallingAnimal("ComeonComeon"); 
            iNterFaceClass.Animallegs(4);



            Console.ReadKey();

        }
     }
}


