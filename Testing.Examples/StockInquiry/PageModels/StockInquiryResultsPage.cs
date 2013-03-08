using System.Collections.Generic;
using System.Linq;
using Models.Domain;
using Testing.Browser;
using Testing.Browser.PageModel;

namespace Testing.Examples.StockInquiry.PageModels
{
    internal class StockInquiryResultsPage : HtmlPage
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

    internal class StockInquiryResults : HtmlFragment
    {
        public StockInquiryResults(IHtmlElement element) : base(element)
        {
        }

        public int Count
        {
            get { return Items.Count(); }
        }

        public SKUResult For(SKU sku)
        {
            return Items.FirstOrDefault(x => x.Colour == sku.Colour &&
                                             x.Size == sku.Size &&
                                             x.StyleCode == sku.Style.Code);
        }

        private IEnumerable<SKUResult> Items
        {
            get { return Children(".result").Select(x => new SKUResult(x)); }
        }
    }
}
