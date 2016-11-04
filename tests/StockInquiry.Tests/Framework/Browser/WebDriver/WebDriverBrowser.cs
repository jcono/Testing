using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using SimpleBrowser.WebDriver;
using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Framework.Browser.WebDriver
{
    public class WebDriverBrowser: IBrowser
    {
        private static readonly Dictionary<TypeOfBrowser, Func<IWebDriver>> BrowserOptions = new Dictionary<TypeOfBrowser, Func<IWebDriver>>
        {
            { TypeOfBrowser.Firefox, () => new FirefoxDriver() },
            { TypeOfBrowser.Chrome, () => new ChromeDriver() },
            { TypeOfBrowser.InternetExplorer, () => new InternetExplorerDriver() },

            { TypeOfBrowser.SimpleBrowser, () => new SimpleBrowserDriver() },
            { TypeOfBrowser.Phantom, () => new PhantomJSDriver() },
            { TypeOfBrowser.Remote, () => new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub"), RemoteCapabilities()) }
        };

        private readonly IWebDriver _driver;

        public WebDriverBrowser(TypeOfBrowser typeOfBrowser)
        {
            _driver = BrowserOptions[typeOfBrowser]();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public void GoTo(string address)
        {
            _driver.Navigate().GoToUrl(new Uri(address));
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            return new HtmlElement(_driver.FindElement(By.CssSelector(cssSelector)));
        }

        public IEnumerable<IHtmlElement> GetElements(string selector)
        {
            return _driver.FindElements(By.CssSelector(selector)).Select(x => new HtmlElement(x));
        }

        private static DesiredCapabilities RemoteCapabilities()
        {
            var capabilities = DesiredCapabilities.Chrome();
            capabilities.SetCapability("browserstack.user", "developer233");
            capabilities.SetCapability("browserstack.key", "rLiLpsc6XBCc4U2yqJe5");

            //            capabilities.SetCapability("browserstack.debug", "true");
            //            capabilities.SetCapability("browser", "Chrome");
            //            capabilities.SetCapability("browser_version", "52.0");
            //            capabilities.SetCapability("os", "Windows");
            //            capabilities.SetCapability("os_version", "10");
            //            capabilities.SetCapability("resolution", "1024x768");

            return capabilities;
        }

        ~WebDriverBrowser()
        {
            try
            {
                Quit();
            }
            catch
            {
                // ignored
            }
        }
    }
}
