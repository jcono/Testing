using System.Collections.Generic;

namespace Testing.Framework.Browser.PageModel
{
    public interface IHtmlElement
    {
        bool Visible { get; }
        string Text { get; }
        bool Exists { get; }

        void Click();

        void Type(string text);

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}
