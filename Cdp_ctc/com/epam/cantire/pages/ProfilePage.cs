using Cdp_ctc.com.epam.cantire.commons.utils;
using Cdp_ctc.com.epam.core.config;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdp_ctc.com.epam.cantire.pages
{
    public class ProfilePage
    {
        public const string PagePath = "/my-account.html";

        public ProfilePage CheckIsPageOpened(string pageTitle)
        {
            WaitingUtils.WaitForPageContainsTitle(pageTitle);
            Assert.True(Driver.GetDriver().Url.Contains(PagePath), "FAILED: Page is not present.");         
            return this;
        }
    }
}
