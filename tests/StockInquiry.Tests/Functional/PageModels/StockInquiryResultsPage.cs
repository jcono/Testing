using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class StockInquiryResultsPage : HtmlPage
    {
        public bool IsReady()
        {
            return Results.IsShown();
        }

        public StockInquiryResults Results => new StockInquiryResults(Child("#stockresults"));
    }
}
