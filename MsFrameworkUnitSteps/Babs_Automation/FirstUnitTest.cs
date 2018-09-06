using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Babs_Automation
{
    [TestClass]
    public class FirstUnitTest
    {
        [AssemblyInitialize]
        public static void Beforeassembly(TestContext testContext)
        {
            Console.WriteLine("Before Assembly");
        }
        [ClassInitialize]
        public static void BeforeClass(TestContext testContext)
        {
            Console.WriteLine("Class Initialize -- Run before tests");
        }
    
        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("Test Initialize ---Run before test");
            Console.WriteLine("Launch browser");
        }
  
        [TestMethod, TestCategory("Smoke Test")]
        public void CreateAccount()
        {
            Console.WriteLine("CREATE A USER ACCOUNT ");
        }

        [TestMethod, TestCategory("UAT Test")]
        public void LogIntoAccount()
        {
            CreateAccount();
            Console.WriteLine("LOG INTO THE APPLICATION ");
        }

        [TestMethod, TestCategory("Regression Test"), Ignore]
        public void LogOutOfAccount()
        {
            LogIntoAccount();
            Console.WriteLine("LOG OUT OF THE ACCOUNT");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("Test Cleanup -- Run after test");
            Console.WriteLine("Close browser");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("Class cleanup");
        }

        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("After Assembly");
        }

    }
}
