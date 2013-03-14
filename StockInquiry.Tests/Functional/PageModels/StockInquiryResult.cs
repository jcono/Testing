using StockInquiry.Models.Domain;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    public class StockInquiryResult : HtmlFragment
    {
        public StockInquiryResult(IHtmlElement element) : base(element)
        {
        }

        public dynamic Location { get { return Child(".location").Text; } }

        public dynamic Quantity { get { return int.Parse(Child(".quantity").Text); } }

        public dynamic SKUId { get { return Child(".skuid").Text; } }
    }
}