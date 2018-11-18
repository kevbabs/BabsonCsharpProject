using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Babs_Automation.Component_Helper;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Babs_Automation.SandBox
{
    [TestClass]
    public class ComboBox        
    {
        [TestMethod]
        public void MenuDropDown()
        {
            try
            {
                NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

                LinkHelper.ClickLink(By.LinkText("Desktops"));
                LinkHelper.ClickLink(By.LinkText("Mac (1)"));

                DropDownHelper.SelectElementByIndex(By.Id("input-sort"), 3);
                Thread.Sleep(1000);
                DropDownHelper.SelectElementByValue(By.Id("input-limit"), "https://demo.opencart.com/index.php?route=product/category&path=20_27&sort=p.price&order=ASC&limit=100");
                Thread.Sleep(1000);
                DropDownHelper.SelectElementByText(By.Id("input-sort"), "Rating (Highest3)");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                GenericHelper.TakeAScreenshot();
                throw;
            }
           
        }

    }
}
