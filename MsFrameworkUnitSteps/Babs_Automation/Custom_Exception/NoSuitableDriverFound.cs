using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Configureation;

namespace Babs_Automation.Custom_Exception
{
    public class NoSuitableDriverFound : Exception

    {
        private BrowserType browserType;

        public NoSuitableDriverFound(string message) : base(message)
        {
            
        }

        public NoSuitableDriverFound(string message, BrowserType getBrowserType) : base(message)
        {
            

        }

          
        
    }
}
