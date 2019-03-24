using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework2
{
    [TestFixture]
    [Category("SignIn")]
    public class SignInFunctionality : BaseTest
    {
        [Test]
        [Property("Author", "ArCiGo")]
        public void TCID5()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();
            Assert.IsTrue(homePage.IsLoaded, "Home page didn't open successfully");

            var signInPage = homePage.Header.ClickSignInButton();
            Assert.IsTrue(signInPage.IsLoaded, "Sign in page didn't open successfully");
        }
    }
}
