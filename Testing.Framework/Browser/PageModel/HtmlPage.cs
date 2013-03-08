namespace Testing.Framework.Browser.PageModel
{
    public abstract class HtmlPage : HtmlModel
    {
        private IBrowser _browser;

        protected override IHtmlElement ContainerElement
        {
            get { return _browser.GetElement("body"); }
        }

        public HtmlPage OnBrowser(IBrowser browser)
        {
            _browser = browser;
            return this;
        }
    }
}
