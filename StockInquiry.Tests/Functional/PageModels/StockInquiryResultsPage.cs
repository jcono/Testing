using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class StockInquiryResultsPage : HtmlPage
    {
        public bool IsReady()
        {
            var results = Child("#stockresults");
            return results.Exists && results.Visible;
        }
    }
}