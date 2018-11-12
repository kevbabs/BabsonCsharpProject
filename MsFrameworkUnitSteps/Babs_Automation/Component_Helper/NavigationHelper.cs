using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Setting;

namespace Babs_Automation.Component_Helper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
           //ObjectRepository.Driver.Navigate().GoToUrl(url);
           ObjectRepository.Driver.Navigate().GoToUrl(url);
        }
    }
}
