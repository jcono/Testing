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
    }
}