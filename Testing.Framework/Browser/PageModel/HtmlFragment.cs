namespace Testing.Framework.Browser.PageModel
{
    public abstract class HtmlFragment : HtmlModel
    {
        private readonly IHtmlElement _containerElement;

        protected HtmlFragment(IHtmlElement element)
        {
            _containerElement = element;
        }

        protected override IHtmlElement ContainerElement
        {
            get { return _containerElement; }
        }
    }
}
