using System;
using AutomationResources;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SampleFramework2
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        /*
         * Setup
         */

        [SetUp]
        public void SetupForEverySingleMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }

        /*
         * CleanUp
         */

        [TearDown]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
