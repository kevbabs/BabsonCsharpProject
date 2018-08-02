using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement.Parent
{
    public class KevNina
        {
            protected string parentName = "Kevin";
            protected int parentAge = 30;
        }

    protected void PickinName()
    {
        Console.WriteLine("My name is {0}", parentName);
    }
    protected void PickinAge()
    {
        Console.WriteLine("My Dad is {0} years old", parentName);
    }


}
