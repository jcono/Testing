using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class StockInquiryPage : HtmlPage
    {
        public bool IsReady()
        {
            return SearchBox.Exists && SearchBox.Visible;
        }

        public void SearchFor(string styleCode)
        {
            SearchBox.Type(styleCode);
            SubmitButton.Click();
        }

        private IHtmlElement SearchBox => Child("input#search");

        private IHtmlElement SubmitButton => Child("input#submit");
    }
}
