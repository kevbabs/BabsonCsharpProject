using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using Babs_Automation.Component_Helper;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Babs_Automation.SandBox.WebElements
{
    /// <summary>
    /// Summary description for TestWebElements
    /// </summary>
    [TestClass]
    public class TestWebElements
    {

        [TestMethod]

        public void Elements()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

             try
             {
                
                ObjectRepository.Driver.FindElement(By.Id("q"));
                //Console.WriteLine(ObjectRepository.Driver.FindElement(By.ClassName("cof"));
                ObjectRepository.Driver.FindElement(By.LinkText("Download"));
                ObjectRepository.Driver.FindElement(By.PartialLinkText("Remote Control"));
                ObjectRepository.Driver.FindElement(By.Name("cx"));
                ObjectRepository.Driver.FindElement(By.TagName("label"));
                ObjectRepository.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/table/tbody/tr/td[1]/center/a[1]/img"));

            }

            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
                throw;
            }

            Thread.Sleep(3000);
            var tagList = ObjectRepository.Driver.FindElements(By.TagName("input"));
            foreach (var tag in tagList)
            {
                if (tag.GetAttribute("value").Equals("Go"))
                {
                    Thread.Sleep(3000);
                    tag.Click();
                }
                break;
            }

            LinkHelper.ClickLink(By.LinkText("Learn more about sponsorship"));
            //LinkHelper.ClickLink(By.PartialLinkText("more about sponsorship"));

        }
    }
}


