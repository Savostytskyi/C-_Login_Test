using Cdp_ctc.com.epam.cantire.commons;
using Cdp_ctc.com.epam.cantire.pages;
using Cdp_ctc.com.epam.core.config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace Cdp_ctc.com.epam.cantire.tests
{
    [TestClass]
    public class BaseTestSetUp

    {
        protected IWebDriver driver;
        protected HomePage homePage;

        [TestInitialize()]
        public void StartupBase()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Constants.MidleDelay));
            driver.Manage().Window.Maximize();
            Driver.SetDriver(driver);
        }

        [TestCleanup()]
        public void CleanupBase()
        {
            driver.Close();
        }
    }
}
