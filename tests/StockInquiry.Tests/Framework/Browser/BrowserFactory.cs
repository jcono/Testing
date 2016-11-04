using System;
using StockInquiry.Tests.Framework.Browser.WebDriver;

namespace StockInquiry.Tests.Framework.Browser
{
    public static class BrowserFactory
    {
        [ThreadStatic]
        private static IBrowser _webDriverBrowser;

        public static IBrowser ForWebDriver()
        {
            if (_webDriverBrowser is WebDriverBrowser)
            {
                return _webDriverBrowser;
            }
            _webDriverBrowser?.Quit();

            _webDriverBrowser = new WebDriverBrowser(TypeOfBrowser.Phantom);
            return _webDriverBrowser;
        }
    }
}
