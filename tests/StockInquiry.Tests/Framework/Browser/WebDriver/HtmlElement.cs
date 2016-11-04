using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Framework.Browser.WebDriver
{
    public class HtmlElement : IHtmlElement
    {
        private readonly IWebElement _element;

        public HtmlElement(IWebElement element)
        {
            _element = element;
        }

        public bool Exists => true;

        public string Text => _element.Text;

        public bool Visible => _element.Displayed;

        public void Click()
        {
            _element.Click();
        }

        public void Type(string text)
        {
            _element.SendKeys(text);
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            var element = GetElements(cssSelector).FirstOrDefault();
            return element ?? new NonExistentElement(cssSelector);
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            var elements = _element.FindElements(By.CssSelector(cssSelector));
            return elements.Select(x => new HtmlElement(x));
        }
    }
}
