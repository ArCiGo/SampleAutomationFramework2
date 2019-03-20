using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using AutomationResources;

namespace SampleFramework2
{
    [TestFixture()]
    [Category("SearchingFeature")]
    public class SearchFunctionality : BaseTest
    {
        [Test]
        [Description("Checks to make sure that if we search for browser, that browser comes back")]
        [Property("Author", "ArCiGo")]
        public void TCID1()
        {
            string stringToSearch = "blouse";

            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search("blouse");

            Assert.IsTrue(searchPage.Contains(Item.Blouse),
                $"When searching for the string => {stringToSearch}, " +
                $"we did not find it in the search results");
        }
    }
}