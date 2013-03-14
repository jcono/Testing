using System.Collections.Generic;
using System.Linq;
using StockInquiry.Models.Domain;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class StockInquiryResults : HtmlFragment
    {
        public StockInquiryResults(IHtmlElement element) : base(element)
        {
        }

        public dynamic Count
        {
            get { return Items.Count(); }
        }

        protected IEnumerable<StockInquiryResult> Items
        {
            get { return Children(".result").Select(x => new StockInquiryResult(x)); }
        }

        public StockInquiryResult For(Stock stock)
        {
            var matchingItem = Items.SingleOrDefault(x => x.Location == stock.Location &&
                                                         x.Quantity == stock.Quantity &&
                                                         x.SKUId == stock.SKU.Id);
            return matchingItem ?? new StockInquiryResult(new NonExistentElement(""));
        }
    }
}
