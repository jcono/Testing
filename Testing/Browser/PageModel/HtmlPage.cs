using Testing.Browser.PageModel;

namespace Testing.Browser
{
    public abstract class HtmlPage : HtmlModel
    {
        private IBrowser _browser;

        protected override IHtmlElement RootElement
        {
            get { return _browser.GetElement("html"); }
        }

        public HtmlPage OnBrowser(IBrowser browser)
        {
            _browser = browser;
            return this;
        }
    }
}
