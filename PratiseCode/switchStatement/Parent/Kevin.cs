using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using switchStatement.Grand_Parent;

namespace switchStatement.Parent
{
    public class Kevin : chiefBabs 
    {
        protected string parentName = "Kevin";
        protected int parentAge = 40;

        protected void FatherName()
        {
            Console.WriteLine("My Dad's name is {0}", parentName);
        }
        protected void FatherAge()
        {
            Console.WriteLine("My Dad's age is {0}", parentAge);
        }

    }

}
