using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement.StaticThings
{
    public class StaticChecks
    {
        public string name;
        public int age;
        public static int staticNumber;

        public void SetValue(int paramsOne)
        {
            staticNumber = paramsOne;
        }

        public void GetValue()
        {
            Console.WriteLine("The value of the static number is {0}", staticNumber);
        }

        // this a static method
        public static void SetStaticValue(int paramTwo)
        {
            staticNumber = paramTwo;
        }

        // this a static method
        public static void GetStaticVale()
        {
            Console.WriteLine("The value of the static number from the " +
                "static method is {0}", staticNumber);
        }


    }
}
