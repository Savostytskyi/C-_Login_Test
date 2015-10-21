using Cdp_ctc.com.epam.cantire.pages;
using Cdp_ctc.com.epam.cantire.tests;
using NUnit.Framework;

namespace Cdp_ctc
{
    [TestFixture]
    public class LoginTests : BaseTestSetUp
    
    {
        [SetUp]
        public void Startup()
        {
            homePage = new HomePage();
        }

        [Test]
        public void LoginUsingCorrectCreds()
        {
            homePage.OpenHomePage("en")
                    .NavigateToLoginPage()
                    .LoginAsRegistresdUser()
                    .checkIsUserLogedIn();
        }
    }

}
