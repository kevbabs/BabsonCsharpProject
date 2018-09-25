using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Configureation;

namespace Babs_Automation.Interfaces
{
    public interface Iconfig
    {
        string GetUsername();
        string GetPassword();
        BrowserType GetBrowser();

        string GetWebsite();
    }
}
