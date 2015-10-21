using Cdp_ctc.com.epam.cantire.commons;
using Cdp_ctc.com.epam.cantire.pages;
using Cdp_ctc.com.epam.core.config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace Cdp_ctc.com.epam.cantire.tests
{
    [TestFixture]
    public class BaseTestSetUp

    {
        protected IWebDriver driver;
        protected HomePage homePage;

        [SetUp]
        public void StartupBase()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Constants.MidleDelay));
            driver.Manage().Window.Maximize();
            Driver.SetDriver(driver);
        }

        [TearDown]
        public void CleanupBase()
        {
            driver.Close();
        }
    }
}
