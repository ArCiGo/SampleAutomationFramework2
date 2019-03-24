using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework2
{
    public class LeftPageSection : BaseApplicationPage
    {
        public LeftPageSection(IWebDriver driver) : base(driver) { }

        public IWebElement SearchForm => Driver.FindElements(By.XPath("//form[@role='search']"))[1];
        public IWebElement SearchBox => Driver.FindElements(By.XPath("//form[@role='search']//input[@id='s']"))[0];
        public IWebElement SearchButton => SearchForm.FindElement(By.Id("searchsubmit"));

        public SearchResultsPage Search(string searchString)
        {
            SearchBox.SendKeys(searchString);
            SearchButton.Click();

            return new SearchResultsPage(Driver);
        }
    }
}
