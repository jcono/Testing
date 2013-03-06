using System.Collections.Generic;

namespace Testing.Browser
{
    public interface IHtmlElement
    {
        bool Visible { get; }
        string Text { get; }
        bool Exists { get; }
        //        string Source { get; }
        //        string Href { get; }
        //        bool IsChecked { get; }
        //
        void Click();

        //
        //        void Clear();
        //
        void Type(string text);

        //
        //        void Select();
        //
        //        void MouseOver();

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}
