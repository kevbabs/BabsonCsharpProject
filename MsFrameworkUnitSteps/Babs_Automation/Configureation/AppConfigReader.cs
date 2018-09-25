using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Interfaces;
using Babs_Automation.Setting;

namespace Babs_Automation.Configureation
{
   public class AppConfigReader :Iconfig
    {
       public string GetUsername()
       {
           return ConfigurationManager.AppSettings.Get(AppconfigKeys.Username);
       }

       public string GetPassword()
       {
            return ConfigurationManager.AppSettings.Get(AppconfigKeys.Password);
        }

       public BrowserType GetBrowser()
       {
           string browser = ConfigurationManager.AppSettings.Get(AppconfigKeys.Browser);
           return (BrowserType) Enum.Parse(typeof(BrowserType), browser);

       }

       public string GetWebsite()
       {
            return ConfigurationManager.AppSettings.Get(AppconfigKeys.Website);
        }
    }
}
