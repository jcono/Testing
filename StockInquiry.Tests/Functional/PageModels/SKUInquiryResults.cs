using System.Collections.Generic;
using System.Linq;
using StockInquiry.Models.Domain;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class SKUInquiryResults : HtmlFragment
    {
        public SKUInquiryResults(IHtmlElement element) : base(element)
        {
        }

        public int Count
        {
            get { return Items.Count(); }
        }

        public SKUResult For(SKU sku)
        {
            
            var matchingItem = Items.FirstOrDefault(x => x.Colour == sku.Colour &&
                                                         x.Size == sku.Size &&
                                                         x.StyleCode == sku.Style.Code);
            return matchingItem ?? new SKUResult(new NonExistentElement(""));
        }

        private IEnumerable<SKUResult> Items
        {
            get { return Children(".result").Select(x => new SKUResult(x)); }
        }
    }
}
