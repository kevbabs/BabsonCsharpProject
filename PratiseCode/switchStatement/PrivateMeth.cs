using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public class PrivateMeth
    {
       private int _childrenAge;
       private string _childrenName;
       protected int childrenPockectMoney;
        private int _secreteOne;
        private int _SecreteTwo ;


        public void ChildrenEnroll(int age, string name)
        {
            _childrenAge = age;
            _childrenName = name;

            Console.WriteLine("{0} is {1} years old", _childrenName, _childrenAge);
            Console.WriteLine("My secrete calculation is {0}", MultipleMe(6,2));
     
        }

        private int MultipleMe(int numA, int numB)
        {
            _secreteOne = numA;
            _SecreteTwo = numB;
            int result = numA*numB;
            return result;
        }
        internal void ChildrenDetails()
        {
            Console.WriteLine("{0} is my age", _childrenAge);
            Console.WriteLine("{0} is my name", _childrenName);
            Console.WriteLine("{0} is my pockect money", childrenPockectMoney);
        }

    }

    
}
