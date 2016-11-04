namespace StockInquiry.Tests.Framework.Browser.PageModel
{
    public abstract class HtmlFragment : HtmlModel
    {
        protected HtmlFragment(IHtmlElement element)
        {
            ContainerElement = element;
        }

        protected override IHtmlElement ContainerElement { get; }
    }
}
