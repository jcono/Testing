using StockInquiry.Models.View;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
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

        public void View()
        {
            Child("a").Click();
        }
    }
}
