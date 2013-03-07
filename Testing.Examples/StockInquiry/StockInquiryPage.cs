using Testing.Browser;

namespace Testing.Examples.StockInquiry
{
    internal class StockInquiryPage : HtmlPage
    {
        public bool IsReady()
        {
            var searchBox = Child("input#search");
            return searchBox.Exists && searchBox.Visible;
        }

        public void SearchFor(string styleCode)
        {
            var searchBox = Child("input#search");
            searchBox.Type(styleCode);

            var submitButton = Child("input#submit");
            submitButton.Click();
        }
    }
}