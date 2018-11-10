using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Babs_Automation.Component_Helper
{
    public class ButtonHelper
    {
        private static IWebElement _element;

        public static bool IsButtonEnable(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            return _element.Enabled ;
        }
        public static void ClickButton(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }
    }
}
