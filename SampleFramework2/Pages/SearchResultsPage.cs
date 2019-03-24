using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework2
{
    public class SearchResultsPage : BaseApplicationPage
    {
        public SearchResultsPage(IWebDriver driver) : base(driver) { }

        public bool IsLoaded => Driver.Url.Contains("?s");
    }
}
