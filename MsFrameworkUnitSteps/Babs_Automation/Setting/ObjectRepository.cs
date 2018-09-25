using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Interfaces;
using OpenQA.Selenium;

namespace Babs_Automation.Setting
{
    public class ObjectRepository

    {

        public static  Iconfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
