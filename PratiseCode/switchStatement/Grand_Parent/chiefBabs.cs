using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement.Grand_Parent
{
    public class chiefBabs
    {
        private string grandPaName = "ChiefBabs";
        private int grandPaAccount = 1000000;

        public void giveMeMoney()
        {
            Console.WriteLine("I have inherited {0}", grandPaAccount);
        }
    }
}
