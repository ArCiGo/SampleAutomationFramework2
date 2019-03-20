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
    }
}
