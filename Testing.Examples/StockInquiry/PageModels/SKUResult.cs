using Testing.Browser;
using Models.View.StockInquiry;

namespace Testing.Examples.StockInquiry.PageModels
{
    internal class SKUResult : HtmlFragment, ISKUResult
    {
        public SKUResult(IHtmlElement element) : base(element)
        {
        }

        public string Colour
        {
            get { return Child(".itemcolour").Text; }
        }

        public string Size
        {
            get { return Child(".itemsize").Text; }
        }

        public string StyleCode
        {
            get { return Child(".itemcode").Text; }
        }
    }
}
