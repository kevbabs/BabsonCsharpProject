using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babs_Automation.Component_Helper;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Babs_Automation.SandBox.Navigation
{
    [TestClass]
    public class TestNavigation
    {
        [TestMethod]
        public void NavigateToNewsWebsite()
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());

          //ObjectRepository.Driver.Navigate().
          //      GoToUrl((ObjectRepository.Config.GetWebsite()));

            NavigationHelper.NavigateToUrl((ObjectRepository.Config.GetWebsite()));
        }
    }
}
