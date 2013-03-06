using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Testing.Browser.WebDriver
{
    public class WebDriverBrowser : IBrowser
    {
        private readonly IWebDriver _driver;

        public WebDriverBrowser()
        {
            _driver = new FirefoxDriver();
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
