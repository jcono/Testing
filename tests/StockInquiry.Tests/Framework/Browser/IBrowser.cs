using System.Collections.Generic;
using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Framework.Browser
{
    public interface IBrowser
    {
        void Quit();

        void GoTo(string url);

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}
