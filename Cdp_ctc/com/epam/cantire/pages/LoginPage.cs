using Cdp_ctc.com.epam.cantire.commons;
using Cdp_ctc.com.epam.cantire.commons.data.provider;
using Cdp_ctc.com.epam.cantire.commons.utils;
using Cdp_ctc.com.epam.core.config;
using OpenQA.Selenium;

namespace Cdp_ctc.com.epam.cantire.pages
{
   public class LoginPage
    {
        public static readonly By Emailfield = By.XPath("(//input[@class='fm-sign-in-form__input-text'])[1]");
        public static readonly By Passfield = By.XPath("(//input[@class='fm-sign-in-form__input-text'])[2]");
        public static readonly By SignInButton = By.XPath("//a[contains(@class, 'fm-sign-in-form__sign-in-button')]");

    public ProfilePage LoginAsRegistresdUser()
    {
            WaitingUtils.WaitForElementLoad(Emailfield, Constants.MidleDelay);
            Driver.GetDriver().FindElement(Emailfield).SendKeys(TestDataProvider.getDataByKey("login"));
            Driver.GetDriver().FindElement(Passfield).SendKeys(TestDataProvider.getDataByKey("password"));
            Driver.GetDriver().FindElement(SignInButton).Click();
            return new ProfilePage();
    }
    }

}
