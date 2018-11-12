using System;
using System.Threading;
using Babs_Automation.Component_Helper;
using Babs_Automation.Setting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Babs_Automation.SandBox.WebElements
{
    [TestClass]
    public class TestWebElements2
    {

        [TestMethod]
        public void Elements2()
        {                                   
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            //help to navigate to the Register page
            ButtonHelper.IsButtonEnable(By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]"));
            Thread.Sleep(4000);
            ButtonHelper.ClickButton(By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]"));
            ButtonHelper.ClickButton(By.PartialLinkText("Register"));

            WaitHelper.WaitForElement(By.XPath("//*[@id='content']/form/fieldset[3]/div/div/label[1]/input"));
            RadioButtonHelper.IsRadioButtonSelected(By.CssSelector("#content > form > fieldset:nth-child(3) > div > div > label:nth-child(1) > input[type='radio']"));
            RadioButtonHelper.ClickRadioButton(By.CssSelector("#content > form > fieldset:nth-child(3) > div > div > label:nth-child(1) > input[type='radio']"));

            WaitHelper.WaitForElement(By.ClassName("agree"));
            Console.WriteLine(CheckboxHelper.IsCheckBoxChecked(By.Name("agree")));
            CheckboxHelper.CheckACheckBox(By.Name("agree"));

        }
    }
}
