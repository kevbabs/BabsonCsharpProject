using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Babs_Automation.Component_Helper
{
    public class DropDownHelper
    {
        private static SelectElement _select;

        public static void SelectElementByIndex(By locator, int indextValue)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByIndex(indextValue);
        }

        public static void SelectElementByText(By locator, string visibleText)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByText(visibleText);
        }

        public static void SelectElementByValue(By locator, string visibleText)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByValue(visibleText);
        }

        public static IList<string> AllDropdownMenuItem(By locator)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            return _select.Options.Select(x => x.Text).ToList();
        }

    }
}
