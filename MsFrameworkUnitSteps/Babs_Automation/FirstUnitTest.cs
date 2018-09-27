using System;
using System.Configuration;
using System.Runtime.InteropServices;
using Babs_Automation.Component_Helper;
using Babs_Automation.Configureation;
using Babs_Automation.Interfaces;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Babs_Automation
{
    [TestClass]
    public class FirstUnitTest
    {
        //private static readonly Iconfig _config = new AppConfigReader();

        //[TestMethod, TestCategory("Smoke Test")]
        //public void LaunchAndCloseBrowser()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        //    driver.FindElement(By.LinkText("Weather")).Click();
        //    driver.Manage().Window.Maximize();
        //    driver.Close();
        //    //driver.Quit();
        //    driver.Dispose();
        //}

        //[TestMethod, TestCategory("Smoke Test"),]
        //public void Navigate()
        //{

        //    ConfigurationManager.AppSettings.Get("Browser");
        //    Console.WriteLine(BrowserType.Chrome);
        //    Console.WriteLine((int)BrowserType.Explorer);
        //}

        [TestMethod]
        public void GoToDefinedWebsite()
        {
            //Console.WriteLine(_config.GetUsername());
            //Console.WriteLine(_config.GetBrowser());
            //Console.WriteLine(_config.GetPassword());

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            var pageTittle = ObjectRepository.Driver.Title;
            Console.WriteLine("The page tittle is: {0}", PageTittleHelper.GetPageTittle());
        }

    }
}
