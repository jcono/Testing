using System.Collections.Generic;

namespace Testing.Browser.PageModel
{
    public abstract class HtmlModel
    {
        protected abstract IHtmlElement ContainerElement { get; }

        public bool IsShown()
        {
            return ContainerElement.Exists && ContainerElement.Visible;
        }

        protected IHtmlElement Child(string cssSelector)
        {
            return ContainerElement.GetElement(cssSelector);
        }

        protected IEnumerable<IHtmlElement> Children(string cssSelector)
        {
            return ContainerElement.GetElements(cssSelector);
        }
    }
}
