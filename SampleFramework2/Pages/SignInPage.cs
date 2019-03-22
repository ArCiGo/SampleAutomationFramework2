using System;
using OpenQA.Selenium;

namespace SampleFramework2
{
    public class SignInPage : BaseApplicationPage
    {
        public SignInPage(IWebDriver driver) : base(driver) { }

        public bool IsLoaded
        {
            get
            {
                var isLoaded = Driver.Url.Contains("controller=authentication");

                return isLoaded;
            }
        }
    }
}
