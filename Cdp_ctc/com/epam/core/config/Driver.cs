using System.Threading;
using OpenQA.Selenium;

namespace Cdp_ctc.com.epam.core.config
{
    class Driver
    {
        public static ThreadLocal<IWebDriver> driverInstance = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriver()
        {
            return driverInstance.Value;
        }

        public static void SetDriver(IWebDriver driver)
        {
            driverInstance.Value = driver;
        }
    }
}
