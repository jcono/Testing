using Testing.Framework.Browser;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional
{
    public class BrowserSteps
    {
        private readonly BrowserTestContext _context;

        protected BrowserSteps(BrowserTestContext context)
        {
            _context = context;
        }

        protected void Launch(string address)
        {
            _context.Launch(address);
        }

        protected T On<T>() where T : HtmlPage, new()
        {
            return _context.On<T>();
        }
    }
}