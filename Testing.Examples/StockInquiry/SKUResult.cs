using Testing.Browser;

namespace Testing.Examples.StockInquiry
{
    internal class SKUResult :HtmlFragment
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