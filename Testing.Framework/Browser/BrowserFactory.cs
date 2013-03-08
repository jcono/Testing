using System;
using Testing.Framework.Browser.WebDriver;

namespace Testing.Framework.Browser
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
            if (_webDriverBrowser != null)
            {
                _webDriverBrowser.Quit();
            }

            _webDriverBrowser = new WebDriverBrowser(TypeOfBrowser.Firefox);
            return _webDriverBrowser;
        }
    }
}
