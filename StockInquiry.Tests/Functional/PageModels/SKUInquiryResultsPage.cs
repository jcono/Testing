using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class SKUInquiryResultsPage : HtmlPage
    {
        public bool IsReady()
        {
            return Results.IsShown();
        }

        public SKUInquiryResults Results
        {
            get { return new SKUInquiryResults(Child("#results")); }
        }
    }
}
