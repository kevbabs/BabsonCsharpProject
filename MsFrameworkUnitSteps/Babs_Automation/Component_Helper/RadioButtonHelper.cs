using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Babs_Automation.Component_Helper
{
    public class RadioButtonHelper
    {
        private static IWebElement _element;

        public static bool IsRadioButtonSelected(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            var radioButtonStatus = _element.GetAttribute("checked");

            if (radioButtonStatus != null) //(checkBox == null) if true code
            {
                return radioButtonStatus.Equals("true") || radioButtonStatus.Equals("checked");
            }
            else
            {
                return false;
            }

        }

        public static void ClickRadioButton(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }

    }
}
