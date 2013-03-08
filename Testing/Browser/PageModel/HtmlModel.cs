using System.Collections.Generic;

namespace Testing.Browser.PageModel
{
    public abstract class HtmlModel
    {
        protected abstract IHtmlElement RootElement { get; }

        public bool IsShown()
        {
            return RootElement.Exists && RootElement.Visible;
        }

        protected IHtmlElement Child(string cssSelector)
        {
            return RootElement.GetElement(cssSelector);
        }

        protected IEnumerable<IHtmlElement> Children(string cssSelector)
        {
            return RootElement.GetElements(cssSelector);
        }
    }
}
