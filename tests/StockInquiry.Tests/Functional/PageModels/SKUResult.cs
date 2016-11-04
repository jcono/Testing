using StockInquiry.Models.View;
using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional.PageModels
{
    internal class SKUResult : HtmlFragment, ISKUResult
    {
        public SKUResult(IHtmlElement element) : base(element)
        {
        }

        public string Colour => Child(".itemcolour").Text;

        public string Size => Child(".itemsize").Text;

        public string StyleCode => Child(".itemcode").Text;

        public void View()
        {
            Child("a").Click();
        }
    }
}
