using System;
using OpenQA.Selenium;

namespace SampleFramework2
{
    public class BaseApplicationPage
    {
        protected IWebDriver Driver { get; set; }

        public BaseApplicationPage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
