using System;
using NUnit.Framework;
using AutomationResources;
using OpenQA.Selenium;

namespace SampleFramework2
{
    [TestFixture]
    [Category("ContactUsPage")]
    public class ContactUsFeature : BaseTest
    {
        [Test]
        [Property("Author", "ArCiGo")]
        [Description("Validate that the contact us page opes successfully with a form")]
        public void TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();

            Assert.IsTrue(contactUsPage.IsLoaded,
                "The contact us page did not open susccessfully");
        }

        [Test]
        [Property("Author", "ArCiGo")]
        [Description("Validate that the contact us page opens when clicking the Contact Us button")]
        public void TCID4()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();

            Assert.IsTrue(homePage.IsLoaded, "Home page did not open successfully");

            var contactUsPage = homePage.Header.ClickContactUsButton();
            Assert.IsTrue(contactUsPage.IsLoaded, "The Contact Us page didn't open successfully");
        }
    }
}
