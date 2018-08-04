using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public class ConstructorMe
    {
        protected string Species;
        protected string Animal;
        protected int numberOfEyes;
        protected int numberOfLegs;
        protected int numberOftail ;

        //public ConstructorMe()
        //{
            
        //}

        public ConstructorMe(string animalType, int eyes, int legs)
        {
            Species = animalType;
            numberOfEyes = eyes;
            numberOfLegs = eyes;

            Console.WriteLine("A {0} has {1} eyes & {2} legs", Species, numberOfEyes, numberOfLegs);
        }

        public ConstructorMe(string animalType, int eyes, int legs, int tail)
        {
            Species = animalType;
            numberOfEyes = eyes;
            numberOfLegs = eyes;
            numberOftail = tail;

            Console.WriteLine("A {0} has {1} eyes {2} legs & {3} " +
                              " tail", Species, numberOfEyes, numberOfLegs, numberOftail);
        }

    }

}
