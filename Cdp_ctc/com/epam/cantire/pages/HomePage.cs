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
        public static readonly By SignInLabel = By.XPath("//div[@data-component='HeaderSignIn']//span[contains(@class,'flyout-toggle__text')]");
        public static readonly By SignInLink = By.XPath("//a[@class='global-sign-in__content__link']");
        public static readonly By BannerButton = By.XPath("//div[@class='banner-builder__button-label']");
        public static readonly By LocaleButton = By.XPath("//a[contains(@class, 'language')]");

        public HomePage OpenHomePage(string locale)
        {
            Driver.GetDriver().Navigate().GoToUrl(TestDataProvider.getDataByKey("url") + "/" + locale + ".html");
            return this;
        }


        public LoginPage NavigateToLoginPage()
    {
            WaitingUtils.WaitForElementLoad(SignInLabel, Constants.ShortDelay);
            Driver.GetDriver().FindElement(SignInLabel).Click();
            WaitingUtils.WaitForElementLoad(SignInLink, Constants.ShortDelay);
            Driver.GetDriver().FindElement(SignInLink).Click();
            return new LoginPage();
    }

        public HomePage checkIsUserLogedIn()
        {
            WaitingUtils.WaitForElementLoad(BannerButton, Constants.ShortDelay);
            if (Driver.GetDriver().FindElement(LocaleButton).GetAttribute("href").Contains("fr"))
            {
                Assert.AreEqual("My Account", Driver.GetDriver().FindElement(SignInLabel).Text);
            } else
            {
                Assert.AreEqual("My Accounte", Driver.GetDriver().FindElement(SignInLabel).Text);
            }
            return this;
        }

    }
}
