using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cdp_ctc.com.epam.cantire.pages;
using Cdp_ctc.com.epam.cantire.tests;

namespace Cdp_ctc
{
    [TestClass]
    public class LoginTests : BaseTestSetUp
    
    {
        [TestInitialize()]
        public void Startup()
        {
            homePage = new HomePage();
        }

        [TestMethod]
        public void LoginUsingCorrectCreds()
        {
            homePage.OpenHomePage("en")
                    .NavigateToLoginPage()
                    .LoginAsRegistresdUser()
                    .checkIsUserLogedIn();
        }
    }

}
