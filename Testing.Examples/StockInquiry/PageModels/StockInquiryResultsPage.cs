using System.Collections.Generic;
using System.Linq;
using Testing.Browser;

namespace Testing.Examples.StockInquiry.PageModels
{
    internal class StockInquiryResultsPage : HtmlPage
    {
        public bool IsReady()
        {
            var results = Child("#results");
            return results.Exists && results.Visible;
        }

        public IEnumerable<SKUResult> Results
        {
            get { return Children(".result").Select(x => new SKUResult(x)); }
        }
    }
}
