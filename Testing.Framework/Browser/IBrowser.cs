using System.Collections.Generic;
using Testing.Framework.Browser.PageModel;

namespace Testing.Framework.Browser
{
    public interface IBrowser
    {
        void Quit();

        void GoTo(string url);

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}
