using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using switchStatement.Parent;

namespace switchStatement.Child
{
    public class Samuel : Kevin // this know as base class
    {
        public string ChildName = "Samuel";
        public int childAge = 10;
   

        public void PickinName()
        {
            Console.WriteLine("My name is {0}", ChildName);
            FatherName();
            giveMeMoney();
            
          
        }
        public void PickinAge()
        {
            Console.WriteLine("I am {0} years old", childAge );
            FatherAge();
        }

        public void CallDaddyName()
        {
            Console.WriteLine("My surname is {0}", parentName);
            
        }

        public void MarriageName()
        {
            parentName = "Nnena";
            Console.WriteLine("My married name is {0}", parentName);
        }

        public void CallDaddyAge()
        {
            Console.WriteLine("My daddy's age {0} year", parentAge);
        }
    }
}
