using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Setting;

namespace Babs_Automation.Component_Helper
{
    public class PageTittleHelper
    {
            public static string GetPageTittle()
            {
                var driverTitle = ObjectRepository.Driver.Title;
                return driverTitle;
            }
     }

    
}
