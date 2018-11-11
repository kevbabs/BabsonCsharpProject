using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Setting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace Babs_Automation.Component_Helper
{
    public class WaitHelper
    {
        private static IWebElement _element;

        public static void WaitForElement(By locator)
        {
            var  wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMilliseconds(15));
            // Lambda expression
            _element = wait.Until(d => d.FindElement(locator));
        }

    }
}
