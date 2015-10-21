using Cdp_ctc.com.epam.cantire.commons.data.provider;
using Cdp_ctc.com.epam.core.config;
using OpenQA.Selenium;

namespace Cdp_ctc.com.epam.cantire.pages
{
   public class LoginPage
    {
        public static readonly string EMAIL_FIELD = "//input[@id='login' or @id='email']";
        public static readonly string PASS_FIELD = "//input[@id='password']";
        public static readonly string SING_IN_BUTTON = "//button[@type='submit']";


    

    public HomePage LoginAsRegistresdUser()
    {
            Driver.GetDriver().FindElement(By.XPath(LoginPage.EMAIL_FIELD)).SendKeys(TestDataProvider.getDataByKey("login"));
            Driver.GetDriver().FindElement(By.XPath(LoginPage.PASS_FIELD)).SendKeys(TestDataProvider.getDataByKey("password"));
            Driver.GetDriver().FindElement(By.XPath(LoginPage.SING_IN_BUTTON)).Click();
            return new HomePage();
    }
    }

}
