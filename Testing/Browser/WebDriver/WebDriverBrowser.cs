using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SimpleBrowser.WebDriver;
using Testing.Browser.PageModel;

namespace Testing.Browser.WebDriver
{
    public class WebDriverBrowser : IBrowser
    {
        private static readonly Dictionary<TypeOfBrowser, Func<IWebDriver>> BrowserOptions = new Dictionary<TypeOfBrowser, Func<IWebDriver>>
        {
            { TypeOfBrowser.Headless, () => new SimpleBrowserDriver() },
            { TypeOfBrowser.Firefox, () => new FirefoxDriver() }
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

        ~WebDriverBrowser()
        {
            try
            {
                Quit();
            }
            catch
            {
            }
        }
    }
}
