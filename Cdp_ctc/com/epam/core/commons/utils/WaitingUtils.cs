using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Cdp_ctc.com.epam.core.config;

namespace Cdp_ctc.com.epam.cantire.commons.utils
{
    class WaitingUtils
    {
        public static void WaitForElementLoad(By by, int timeoutInMilliSeconds)
        {
            if (timeoutInMilliSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromMilliseconds(timeoutInMilliSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
        }
    }
}
