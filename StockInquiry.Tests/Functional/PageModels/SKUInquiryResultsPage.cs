using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class SKUInquiryResultsPage : HtmlPage
    {
        public bool IsReady()
        {
            return Results.IsShown();
        }

        public StockInquiryResults Results
        {
            get { return new StockInquiryResults(Child("#results")); }
        }
    }
}
