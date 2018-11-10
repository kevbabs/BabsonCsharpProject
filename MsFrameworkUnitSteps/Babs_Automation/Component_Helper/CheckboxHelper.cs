using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Babs_Automation.Component_Helper
{
    public class CheckboxHelper
    {
        private static IWebElement _element;
        public static void CheckACheckBox(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }

        public static bool IsCheckBoxChecked(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            var checkBox = _element.GetAttribute("type");

            if (checkBox != null) //(checkBox == null) if true code
            {
                return false;
            }
            else
            {
                return checkBox.Equals("checkbox") || checkBox.Equals("true");
            }
        }
    }
}
