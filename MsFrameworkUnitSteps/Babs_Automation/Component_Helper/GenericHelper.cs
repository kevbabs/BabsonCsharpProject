using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Setting;
using OpenQA.Selenium;

namespace Babs_Automation.Component_Helper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element is not present" + locator.ToString());
            }
        }
    }
}
