using Testing.Browser;

namespace StockInquiry.Tests
{
    public class HomePage: HtmlPage
    {
        public void SearchFor(string abc)
        {
            SearchBox.Type(abc);
        }

        protected IHtmlElement SearchBox
        {
            get { return Child("#searchform"); }
        }

        protected IHtmlElement Document
        {
            get { return RootElement; }
        }
    }

}