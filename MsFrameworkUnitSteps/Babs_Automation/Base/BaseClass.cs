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

#region BrowerOptions
        private static ChromeOptions GetChromeOptions()
        {
            var cOptions = new ChromeOptions();
            cOptions.AddArgument("start-maximized");
            return cOptions;
        }


        private static InternetExplorerOptions GetIEOptions()
        {
           var iEOptions = new InternetExplorerOptions();
            {
                iEOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                iEOptions.EnsureCleanSession = true;
                
            }
            return iEOptions;
        }

        private static FirefoxProfile GetFirefoxOptions()
        {
            var  fOptions = new FirefoxProfile();
            var fxManager = new FirefoxProfileManager();
            fOptions = fxManager.GetProfile("default");
            return fOptions;
        }

        private static ChromeOptions GetMoreChromeOptions()
        {
            var  mChromeOptions  = new ChromeOptions();
            mChromeOptions.AddArgument("--Headless");
            return mChromeOptions;
;        }

        #endregion


#region DriversInstances
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static IWebDriver GetExtraChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetMoreChromeOptions());
            return driver;
        }

        #endregion


#region BrowerLanch
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

                case BrowserType.ChromeHeadless:
                    ObjectRepository.Driver = GetExtraChromeDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver not find {0}", ObjectRepository.Config.GetBrowser());
                        
  
            }

            // This page load wait which handle better that specifield implicit wait
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(15);

            // thsi how implement implicit wait
           // ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);
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

#endregion
    }
}
