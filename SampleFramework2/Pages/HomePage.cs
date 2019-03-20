using System;
using NLog;
using OpenQA.Selenium;

namespace SampleFramework2
{
    public class HomePage : BaseApplicationPage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public HomePage(IWebDriver driver) : base(driver) 
        {
            Slider = new Slider(driver);
        }

        public Slider Slider { get; set; }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        internal SearchPage Search(string itemToSearchFor)
        {
            Driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
            Driver.FindElement(By.Name("submit_search")).Click();

            return new SearchPage(Driver);
        }
    }
}