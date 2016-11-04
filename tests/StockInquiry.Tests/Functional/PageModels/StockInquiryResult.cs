using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    public class StockInquiryResult: HtmlFragment
    {
        public StockInquiryResult(IHtmlElement element): base(element)
        {
        }

        public dynamic Location => Child(".location").Text;

        public dynamic Quantity => int.Parse(Child(".quantity").Text);

        public dynamic SKUId => Child(".skuid").Text;
    }
}
