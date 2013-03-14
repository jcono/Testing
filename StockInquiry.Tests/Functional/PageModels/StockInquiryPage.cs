using Testing.Framework.Browser.PageModel;

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

        private IHtmlElement SearchBox
        {
            get { return Child("input#search"); }
        }

        private IHtmlElement SubmitButton
        {
            get { return Child("input#submit"); }
        }
    }
}
