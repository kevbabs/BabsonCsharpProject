using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Configureation;
using Babs_Automation.Custom_Exception;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Babs_Automation.Base
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext testContext)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver not find {0}", ObjectRepository.Config.GetBrowser());
                        
                        
                        

            }
        }

        [AssemblyCleanup]
        public static void TearDowm()
        {
            if (ObjectRepository.Driver !=null)
            {
                //ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
                //ObjectRepository.Driver.Dispose();
            }
        }
    }
}
