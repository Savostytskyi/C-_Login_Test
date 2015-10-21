using Cdp_ctc.com.epam.cantire.commons;
using Cdp_ctc.com.epam.cantire.commons.data.provider;
using Cdp_ctc.com.epam.cantire.commons.utils;
using Cdp_ctc.com.epam.core.config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Cdp_ctc.com.epam.cantire.pages
{
   public class HomePage
    {
        public static readonly By SignInLink = By.XPath("//a[contains(@href,'/login.html')]");

        public HomePage OpenHomePage(string locale)
        {
            Driver.GetDriver().Navigate().GoToUrl(TestDataProvider.getDataByKey("url") + "/" + locale + ".html");
            return this;
        }


        public LoginPage NavigateToLoginPage()
    {
            WaitingUtils.WaitForElementLoad(SignInLink, Constants.ShortDelay);
            Driver.GetDriver().FindElement(SignInLink).Click();
            return new LoginPage();
    }
    }
}
