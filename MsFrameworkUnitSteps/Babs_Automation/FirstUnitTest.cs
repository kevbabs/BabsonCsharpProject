using System;
using System.Configuration;
using System.Runtime.InteropServices;
using Babs_Automation.Configureation;
using Babs_Automation.Interfaces;
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
        public void SimpleMethod()
        {
            //Console.WriteLine(_config.GetUsername());
            //Console.WriteLine(_config.GetBrowser());
            //Console.WriteLine(_config.GetPassword());
        }

    }
}
