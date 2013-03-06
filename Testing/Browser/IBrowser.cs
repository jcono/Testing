using System.Collections.Generic;

namespace Testing.Browser
{
    public interface IBrowser
    {
        void Quit();

        void GoTo(string url);

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}
