using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework2
{
    public class ComplicatedPage : BaseApplicationPage
    {
        public ComplicatedPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/complicated-page/");
        }

        public bool IsLoaded
        {
            get
            {
                var isLoaded = Driver.Url.Contains("complicated-page");

                return isLoaded;
            }
        }

        public RandomStuffSection RandomStuffSection => new RandomStuffSection(Driver);
    }
}
