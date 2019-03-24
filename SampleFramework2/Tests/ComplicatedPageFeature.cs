using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework2
{
    [TestFixture]
    [Category("Complicated page")]
    public class ComplicatedPageFeature : BaseTest
    {
        ComplicatedPage complicatedPage;

        [SetUp]
        public void OpenComplicatedPage()
        {
            complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.GoTo();

            Assert.IsTrue(complicatedPage.IsLoaded, "The complicated page didn't open");
        }

        [Test]
        [Property("Author", "ArCiGo")]
        public void TCID6()
        {
            complicatedPage.RandomStuffSection.FillOutFormAndSubmit("my name", "x@x.com", "my message");

            Assert.IsTrue(complicatedPage.RandomStuffSection.IsFormSubmitted, "The form wasn't submitted successfully");
        }

        [Test]
        [Property("Author", "ArCiGo")]
        public void TCID7()
        {
            var searchResultsPage = complicatedPage.RandomStuffSection.LeftPane.Search("selenium errors");

            Assert.IsTrue(searchResultsPage.IsLoaded, "The search page didn't open");
        }
    }
}
