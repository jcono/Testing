namespace StockInquiry.Tests.Framework.Browser.PageModel
{
    public abstract class HtmlPage : HtmlModel
    {
        private IBrowser _browser;

        protected override IHtmlElement ContainerElement => _browser.GetElement("body");

        public HtmlPage OnBrowser(IBrowser browser)
        {
            _browser = browser;
            return this;
        }
    }
}
