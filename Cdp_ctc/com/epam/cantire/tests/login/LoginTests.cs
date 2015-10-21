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

        [Test, TestCaseSource("LocaleData")]
        public void LoginUsingCorrectCreds(string locale, string title)
        {
            homePage.OpenHomePage(locale)
                    .NavigateToLoginPage()
                    .LoginAsRegistresdUser()
                    .CheckIsPageOpened(title);
        }

        static object[] LocaleData =
        {
            new object[] { "en", "My Account"},
            new object[] { "fr", "Mon Compte"},
        };
    }

}
