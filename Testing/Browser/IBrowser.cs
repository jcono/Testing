using System.Collections.Generic;
using Testing.Browser.PageModel;

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
